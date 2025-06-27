# Blazor Nutrient Web Viewer Sample

This is a Blazor server side project demonstrating integration with the Nutrient Viewer library for displaying PDF documents in the browser.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- A modern web browser

### Running the Project

1. Clone this repository or download the source code.
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages and build the project.
4. Press `F5` or select __Debug > Start Debugging__ to run the application.

## Integrating the Nutrient Viewer Library

Nutrient Viewer library files are distributed as an archive that you extract manually:

1. **Download the framework**  
   Download the Nutrient Viewer framework [https://my.nutrient.io/download/web/latest](#) (opens in a new tab). The download will start immediately and will save a `.tar.gz` archive like `PSPDFKit-Web-binary-1.0.0.tar.gz` to your computer.

2. **Extract the archive**  
   Once the download is complete, extract the archive and copy the entire contents of its `dist` folder to the `wwwroot` directory in your project.

3. **Verify the files**  
   Make sure your `wwwroot` folder contains:
   - The file `nutrient-viewer.js`
   - A `nutrient-viewer-lib` directory with library assets

## Project Structure

- `Components/App.razor`  
  Main application component. Includes script references and the PDF loading logic for Nutrient Viewer.
- `Home.razor`  
  Home page component that initializes the Nutrient Viewer and loads a sample PDF document.
- `Program.cs`  
  Application entry point. Configures services and middleware.
- `wwwroot/`  
  Static web assets, including the Nutrient Viewer library files.

## Notes

- The Nutrient Viewer library can be used without a license key, but a watermark will be displayed.
- The PDF viewer is customized to remove zoom and pan buttons from the toolbar.
- [Author](https://www.linkedin.com/in/narashimank/)
## License

This project is for demonstration purposes. Refer to the Nutrient Viewer license for usage terms.
