# Jaywing Tech Test

This site was created as part of a technical test for [Jaywing](https://www.jaywing.com/). It is a simple umbraco build with a call to a cat fact API.

## Setup

After cloning the project, install and run the npm build in the `src/JaywingTechTest.Frontend` folder:

```bash
npm install
npm run deploy
```

You can then run the website with `dotnet run` in the `src/JaywingTechTest.Web` folder or with the usual Visual Studio functionality.

Umbraco is set to install unattended; the default login credentials are stored in the `src/JaywingTechTest.Web/appsettings.Development.json` file.

If usync doesn't run automatically, run it, as all settings and content are stored with that.

And that's it!

## Contributing

Don't! This is a showcase of what I can do, and is only public to make it easier to share with Jaywing.