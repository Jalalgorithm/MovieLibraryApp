# Movie Library App

## Overview
The **Movie Library App** is a .NET-based application that allows users to manage and explore a collection of movies. It provides functionalities such as adding, updating, deleting, and searching for movies. The app is built using **ASP.NET Core** for the backend and **Blazor WebAssembly** for the frontend, ensuring a responsive and interactive user experience.

## Features
- **User Authentication**: Secure login and registration system.
- **Movie Management**: Add, update, and delete movie records.
- **Search & Filter**: Find movies based on title, genre, or release date.
- **Ratings & Reviews**: Users can rate and review movies.
- **Responsive UI**: Built with Blazor WebAssembly for a seamless experience.
- **REST API**: Exposes endpoints for movie data management.

## Technologies Used
- **Backend**: ASP.NET Core Web API
- **Database**: SQL Server 
- **Authentication**: JWT (JSON Web Token)
- **ORM**: Entity Framework Core

## Installation
### Prerequisites
Ensure you have the following installed on your system:
- .NET 7.0 or later
- SQL Server or PostgreSQL
- Visual Studio / VS Code
- Node.js (for package management, if needed)

### Steps to Run the App
1. **Clone the repository**:
   ```sh
   git clone https://github.com/your-repo/movie-library.git
   cd movie-library
   ```
2. **Set up the database**:
   - Update the `appsettings.json` with your database connection string.
   - Run migrations:
     ```sh
     dotnet ef database update
     ```
3. **Run the backend**:
   ```sh
   cd MovieLibrary.API
   dotnet run
   ```
4. **Run the frontend**:
   ```sh
   cd MovieLibrary.Blazor
   dotnet run
   ```
5. Open `http://localhost:5000` in your browser.

## API Endpoints
| Method | Endpoint              | Description               |
|--------|----------------------|---------------------------|
| GET    | `/api/movies`        | Get all movies            |
| GET    | `/api/movies/{id}`   | Get a movie by ID        |
| POST   | `/api/movies`        | Add a new movie          |
| PUT    | `/api/movies/{id}`   | Update an existing movie |
| DELETE | `/api/movies/{id}`   | Delete a movie           |

## Contribution
Contributions are welcome! To contribute:
1. Fork the repository.
2. Create a new branch (`feature/your-feature-name`).
3. Commit your changes.
4. Push to your branch and submit a pull request.

## License
This project is licensed under the MIT License. See `LICENSE` for more details.

## Contact
For any inquiries or support, please reach out at temitomzi@gmail.com.

