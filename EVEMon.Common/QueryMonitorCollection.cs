﻿using System;
using System.Collections.Generic;
using System.Linq;
using EVEMon.Common.Collections;
using EVEMon.Common.Serialization.API;

namespace EVEMon.Common
{
    public sealed class QueryMonitorCollection : ReadonlyCollection<IQueryMonitor>
    {
        /// <summary>
        /// Gets the monitor for the given query.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public IQueryMonitor this[string method]
        {
            get { return Items.FirstOrDefault(monitor => monitor.Method.ToString() == method); }
        }

        /// <summary>
        /// Gets true when at least one of the monitors encountered an error on last try.
        /// </summary>
        public bool HasErrors
        {
            get { return Items.Any(x => x.LastResult != null && x.LastResult.HasError); }
        }

        /// <summary>
        /// Gets the last API results gotten.
        /// </summary>
        public IEnumerable<IAPIResult> APIResults
        {
            get { return Items.Where(x => x.LastResult != null).Select(x => x.LastResult); }
        }

        /// <summary>
        /// Gets the list of monitors to be auto-updated, ordered from the earliest to the latest.
        /// </summary>
        public IEnumerable<IQueryMonitor> OrderedByUpdateTime
        {
            get
            {
                IOrderedEnumerable<IQueryMonitor> monitors = Items.OrderBy(x => x.NextUpdate);

                // Returns the monitors which are planned for an autoupdate
                foreach (IQueryMonitorEx monitor in monitors.Select(monitor => (IQueryMonitorEx)monitor).Where(
                    monitor => monitor.Status == QueryStatus.Pending || monitor.Status == QueryStatus.Updating))
                {
                    yield return monitor;
                }

                // Returns the monitors which won't autoupdate
                foreach (IQueryMonitorEx monitor in monitors.Select(monitor => (IQueryMonitorEx)monitor).Where(
                    monitor => monitor.Status != QueryStatus.Pending && monitor.Status != QueryStatus.Updating))
                {
                    yield return monitor;
                }
            }
        }

        /// <summary>
        /// Gets the next query to be auto-updated, or null.
        /// </summary>
        public IQueryMonitor NextMonitorToBeUpdated
        {
            get
            {
                DateTime nextTime = DateTime.MaxValue;
                IQueryMonitor nextMonitor = null;
                foreach (IQueryMonitorEx monitor in Items)
                {
                    if (monitor.Status != QueryStatus.Pending && monitor.Status != QueryStatus.Updating)
                        continue;

                    DateTime monitorNextTime = monitor.NextUpdate;
                    if (monitorNextTime >= nextTime)
                        continue;

                    nextMonitor = monitor;
                    nextTime = monitorNextTime;
                }
                return nextMonitor;
            }
        }

        /// <summary>
        /// Requests an update for the given method.
        /// </summary>
        /// <param name="method"></param>
        public void Query(Enum method)
        {
            if (method == null)
                throw new ArgumentNullException("method");

            IQueryMonitorEx monitor = this[method.ToString()] as IQueryMonitorEx;
            if (monitor != null && monitor.HasAccess)
                monitor.ForceUpdate(false);
        }

        /// <summary>
        /// Requests an update for the specified methods.
        /// </summary>
        /// <param name="methods">The methods.</param>
        public void Query(IEnumerable<Enum> methods)
        {
            IEnumerable<IQueryMonitorEx> monitors = methods.Select(apiMethod => this[apiMethod.ToString()]).Cast<IQueryMonitorEx>();
            foreach (IQueryMonitorEx monitor in monitors.Where(monitor => monitor.HasAccess))
            {
                monitor.ForceUpdate(false);
            }
        }

        /// <summary>
        /// Requests an update for all monitor.
        /// </summary>
        public void QueryEverything()
        {
            foreach (IQueryMonitorEx monitor in Items.Where(monitor => monitor.HasAccess))
            {
                monitor.ForceUpdate(false);
            }
        }

        /// <summary>
        /// Adds this monitor to the collection.
        /// </summary>
        /// <param name="monitor"></param>
        internal void Add(IQueryMonitorEx monitor)
        {
            Items.Add(monitor);
        }

        /// <summary>
        /// Removes this monitor from the collection.
        /// </summary>
        /// <param name="monitor"></param>
        internal void Remove(IQueryMonitorEx monitor)
        {
            Items.Remove(monitor);
        }
    }
}