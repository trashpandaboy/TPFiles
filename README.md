# TPFiles

TPFiles is a simple file manager for Unity, designed to help you easily read and write files in your Unity projects.

## Features

- Write content to a file
- Load content from a file
- Handles exceptions and logs errors

## Installation

To install this package in your Unity project use the unity Package Manager

## Usage

### Writing to a File

To write content to a file, use the `WriteToFile` method:

```csharp
using com.trashpandaboy.files;

bool success = FileManager.WriteToFile("example.txt", "Hello, World!");
if (success)
{
    Debug.Log("File written successfully.");
}
else
{
    Debug.LogError("Failed to write file.");
}
```

### Loading from a File

To load content from a file, use the [`LoadFromFile`](command:_github.copilot.openSymbolFromReferences?%5B%22%22%2C%5B%7B%22uri%22%3A%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2FUsers%2Fwilliamsoro%2FSource%2FTPFiles%2FRuntime%2FFileManager.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22pos%22%3A%7B%22line%22%3A36%2C%22character%22%3A27%7D%7D%5D%2C%221e6428d4-f44f-44d1-a85c-deb7cf3ac4ff%22%5D "Go to definition") method:

```csharp
using com.trashpandaboy.files;

bool success = FileManager.LoadFromFile("example.txt", out string content);
if (success)
{
    Debug.Log("File loaded successfully: " + content);
}
else
{
    Debug.LogError("Failed to load file.");
}
```

## License

This project is licensed under the Unlicense. For more details, see the `LICENSE` file.