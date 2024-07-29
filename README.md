# WPF CRUD Forms Generator
A code generator program to create CRUD forms based on class objects

## Overview

The WPF CRUD Form Generator is a tool designed to streamline the development of CRUD (Create, Read, Update, Delete) forms in WPF applications. By leveraging class metadata, this tool generates XAML and code-behind files for List, Edit, and Add views based on a specified class. This automation significantly reduces the time and effort required to create repetitive CRUD operations.

## Features

- **Automatic Generation**: Generates List, Edit, and Add forms based on class metadata.
- **Customization**: Supports customizable templates for XAML and code-behind files.
- **Consistency**: Ensures uniform design and implementation across all CRUD forms.
- **Scalable**: Easily extendable to accommodate more complex scenarios and additional features.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or higher)
- Basic understanding of C# and WPF
- [Visual Studio](https://visualstudio.microsoft.com/) or any C# compatible IDE


### Installation (In-progress project - Will be implemented in future)

1. Clone the Repository
2. Open the Solution
3. Build the Solution
    - Build the project to restore dependencies and ensure everything is set up correctly.

### Usage (In-progress project - Will be implemented in future)

1. **Define Your Class**:
    Define the class for which you want to generate CRUD forms. Annotate properties as needed.

2. **Run the Code Generator**:
    - Execute the `CodeGenerator` program. This will read the class metadata and generate the necessary XAML and code-behind files.

3. **Generated Files**:
    - The generated files will be saved in the specified output directory. Add these files to your WPF project.

4. **Integrate and Customize**:
    - Integrate the generated XAML and code-behind files into your WPF application.
    - Customize the templates and generated code as needed to fit your specific requirements.

## Templates

The tool uses templates for generating the XAML and code-behind files. You can customize these templates to match your design and functionality requirements.

Currently there are three templates that will be created
- **ListTemplate.xaml**:

- **EditTemplate.xaml**:

- **AddTemplate.xaml**:

## Contributing

We welcome contributions to enhance the functionality and features of this tool. Feel free to fork the repository, make changes, and submit pull requests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

Special thanks to the contributors and the open-source community for their support and contributions.

