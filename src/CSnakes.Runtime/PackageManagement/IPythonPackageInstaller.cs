using CSnakes.Runtime.EnvironmentManagement;

namespace CSnakes.Runtime.PackageManagement;

/// <summary>
/// Represents an interface for installing Python packages.
/// </summary>
public interface IPythonPackageInstaller
{
    /// <summary>
    /// Installs the specified packages.
    /// </summary>
    /// <param name="home">The home directory.</param>
    /// <param name="virtualEnvironmentLocation">The location of the virtual environment (optional).</param>
    /// <returns>A task representing the asynchronous package installation operation.</returns>
    Task InstallPackages(string home, IEnvironmentManagement? environmentManager);

    /// <summary>
    /// Install a single package.
    /// </summary>
    /// <param name="home">The home directory.</param>
    /// <param name="environmentManager">The location of the virtual environment (optional).</param>
    /// <param name="package">Name of the package to install.</param>
    /// <returns>A task representing the asynchronous package installation operation.</returns>
    Task InstallPackage(string home, IEnvironmentManagement? environmentManager, string package);
}
