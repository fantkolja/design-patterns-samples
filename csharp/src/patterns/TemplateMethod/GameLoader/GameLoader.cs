namespace DesignPatterns.TemplateMethod;

public abstract class BaseGameLoader
{
    public void Load()
    {
        byte[] data = LoadLocalData();
        CreateObjects(data);
        DownloadAdditionalFiles();
        CleanTempFiles();
        InitializeProfiles();
    }

    protected abstract byte[] LoadLocalData();

    protected abstract void CreateObjects(byte[] data);

    protected abstract void DownloadAdditionalFiles();

    protected abstract void InitializeProfiles();

    protected virtual void CleanTempFiles()
    {
        Console.WriteLine("Cleaning temporary files...");
        // Some Common Code...
    }
}

public class WorldOfWarcraftLoader : BaseGameLoader
{
    protected override byte[] LoadLocalData()
    {
        Console.WriteLine("Loading local WoW files...");
        // Some Warcraft Code...
        return new byte[0];
    }

    protected override void CreateObjects(byte[] data)
    {
        Console.WriteLine("Creating WoW objects...");
        // Some Warcraft Code...
    }

    protected override void DownloadAdditionalFiles()
    {
        Console.WriteLine("Downloading WoW sounds...");
        // Some Warcraft Code...
    }

    protected override void InitializeProfiles()
    {
        Console.WriteLine("Loading WoW profiles...");
        // Some Warcraft Code...
    }
}

public class DiabloLoader : BaseGameLoader
{
    protected override byte[] LoadLocalData()
    {
        Console.WriteLine("Loading Diablo files...");
        // Some Diablo Code...
        return new byte[0];
    }

    protected override void CreateObjects(byte[] data)
    {
        Console.WriteLine("Creating Diablo objects...");
        // Some Diablo Code...
    }

    protected override void DownloadAdditionalFiles()
    {
        Console.WriteLine("Downloading Diablo sounds...");
        // Some Diablo Code...
    }

    protected override void InitializeProfiles()
    {
        Console.WriteLine("Loading Diablo profiles...");
        // Some Diablo Code...
    }
}

// BaseGameLoader wowLoader = new WorldOfWarcraftLoader();
// wowLoader.Load();
//
// Console.WriteLine("==========================================");
//
// BaseGameLoader diabloLoader = new DiabloLoader();
// diabloLoader.Load();
