# MfaDiogenes

This project is a sample implementation of Multi-Factor Authentication (MFA) in a .NET Core 8 application. It demonstrates how to enhance the security of a web application by integrating MFA, requiring users to verify their identity using both their password and an additional verification code from an authenticator app, such as Google Authenticator or Authy. This project uses SQLite as the database, making it simple to set up and run locally.

# Key Features
- Two-Factor Authentication (2FA): Users are prompted to enable two-factor authentication for added security. Once enabled, they need to enter a code from an authenticator app at login.
- QR Code Generation: Utilizes the QRCoder library to generate QR codes for easy setup in authenticator apps.
- SQLite Database: A lightweight, file-based database for easy configuration and testing.
- ASP.NET Core Identity: Uses ASP.NET Core Identity for user management, including user registration, login, and MFA setup.

## Prerequisites

Ensure you have the following installed on your system:

- [.NET Core SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0) (or compatible version specified by the project)
- [SQLite](https://sqlite.org/download.html) if using SQLite as the database
- (Optional) [JetBrains Rider](https://www.jetbrains.com/rider/) or any preferred .NET Core IDE

## Getting Started

### 1. Clone the Repository

Clone the project repository to your local machine using the following command:

```bash
git clone https://github.com/DiogenesPolanco/MfaDiogenes.git
cd MfaDiogenes
```

### 2. Configure the Database (SQLite)

Make sure your database is set up correctly. This project is configured to use SQLite by default. You can modify the database connection string in `appsettings.json` if needed:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=MfaDiogenesDb.db"
  }
}
```

### 3. Apply Migrations

To ensure your database schema is up to date, apply any pending migrations:

```bash
dotnet ef database update
```

> **Note:** Make sure that the `dotnet-ef` CLI tool is installed. You can install it globally with:
> ```bash
> dotnet tool install --global dotnet-ef
> ```

### 4. Run the Project

To start the application, use the following command:

```bash
dotnet run
```

This will start the application on the default port. You should see output indicating that the app is running, such as:

```plaintext
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

### 5. Access the Application

Once the application is running, open a web browser and navigate to:

```
http://localhost:5000
```

## Building for Production

To publish and build the application for production:

```bash
dotnet publish --configuration Release
```

This will output the files to the `./bin/Release/netcoreapp8.0/publish` directory (adjust path based on your .NET Core version).

## Additional Notes

- **MFA (Multi-Factor Authentication)**: If MFA is enabled in this project, you may need to scan a QR code and use an authenticator app during the login process.
- **Environment Variables**: Set any required environment variables for sensitive information, like API keys, in the `.env` file or in your system’s environment settings.
