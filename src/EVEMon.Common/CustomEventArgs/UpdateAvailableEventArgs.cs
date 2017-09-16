using System;

namespace EVEMon.Common.CustomEventArgs
{
    public sealed class UpdateAvailableEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAvailableEventArgs"/> class.
        /// </summary>
        /// <param name="forumUrl">The forum URL.</param>
        /// <param name="installerUrl">The installer URL.</param>
        /// <param name="updateMessage">The update message.</param>
        /// <param name="currentVersion">The current version.</param>
        /// <param name="newestVersion">The newest version.</param>
        /// <param name="md5Sum">The MD5 sum.</param>
        /// <param name="canAutoInstall">if set to <c>true</c> [can auto install].</param>
        /// <param name="installArgs">The install args.</param>
        public UpdateAvailableEventArgs(Uri forumUrl, Uri installerUrl, string updateMessage,
                                        Version currentVersion, Version newestVersion, string md5Sum,
                                        bool canAutoInstall, string installArgs)
        {
            ForumUrl = forumUrl;
            InstallerUrl = installerUrl;
            UpdateMessage = updateMessage;
            CurrentVersion = currentVersion;
            NewestVersion = newestVersion;
            MD5Sum = md5Sum;
            CanAutoInstall = canAutoInstall;
            AutoInstallArguments = installArgs;
        }

        /// <summary>
        /// Gets the forum URL.
        /// </summary>
        /// <value>The forum URL.</value>
        public Uri ForumUrl { get; }

        /// <summary>
        /// Gets the installer URL.
        /// </summary>
        /// <value>The auto install URL.</value>
        public Uri InstallerUrl { get; }

        /// <summary>
        /// Gets the update message.
        /// </summary>
        /// <value>The update message.</value>
        public string UpdateMessage { get; }

        /// <summary>
        /// Gets the current version.
        /// </summary>
        /// <value> The current version.</value>
        public Version CurrentVersion { get; }

        /// <summary>
        /// Gets the newest version.
        /// </summary>
        /// <value>The newest version.</value>
        public Version NewestVersion { get; }

        /// <summary>
        /// Gets the MD5 sum.
        /// </summary>
        /// <value>The M d5 sum.</value>
        public string MD5Sum { get; }

        /// <summary>
        /// Gets a value indicating whether this instance can auto install.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance can auto install; otherwise, <c>false</c>.
        /// </value>
        public bool CanAutoInstall { get; }

        /// <summary>
        /// Gets the auto install arguments.
        /// </summary>
        /// <value>The auto install arguments.</value>
        public string AutoInstallArguments { get; }
    }
}