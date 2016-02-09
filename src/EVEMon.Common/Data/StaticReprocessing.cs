using System.Collections.Generic;
using System.Linq;
using EVEMon.Common.Serialization.Datafiles;

namespace EVEMon.Common.Data
{
    /// <summary>
    /// Stores all the data regarding reprocessing.
    /// </summary>
    public static class StaticReprocessing
    {
        private static readonly Dictionary<int, MaterialCollection> s_itemMaterialsByID = new Dictionary<int, MaterialCollection>();

        /// <summary>
        /// Initialize static reprocssing information.
        /// </summary>
        internal static void Load()
        {
            ReprocessingDatafile datafile = Util.DeserializeDatafile<ReprocessingDatafile>(
                DatafileConstants.ReprocessingDatafile, Util.LoadXslt(Properties.Resources.DatafilesXSLT));

            foreach (SerializableItemMaterials item in datafile.Items)
            {
                MaterialCollection materials = new MaterialCollection(item.Materials.Select(itemMaterial => new Material(itemMaterial)));
                s_itemMaterialsByID[item.ID] = materials;
            }
        }

        /// <summary>
        /// Gets an enumeration of all the reprocessing materials.
        /// </summary>
        public static IEnumerable<MaterialCollection> AllReprocessingMaterials => s_itemMaterialsByID.Values;

        /// <summary>
        /// Gets the materials for the provided itemID.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public static IEnumerable<Material> GetItemMaterialsByID(int id)
        {
            MaterialCollection result;
            s_itemMaterialsByID.TryGetValue(id, out result);
            return result;
        }
    }
}