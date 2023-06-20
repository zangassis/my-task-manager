# My Task Manager 📑✅

This is the repository for the backend of the My Task Manager application, a system for task management. 
The backend is developed using the .NET 7 framework and utilizes SQLite as the database. It also utilizes EF Core for data access and the mapping of Data Transfer Objects (DTOs) is done manually without the use of any frameworks.

## Technologies Used 🛠️

- .NET 7
- SQLite
- Entity Framework Core (EF Core)

## Getting Started 🚦

To get started with the My Task Manager backend, follow these steps:

1. **Prerequisites:** Make sure you have the following installed:
   - .NET 7 SDK: [Download Here](https://dotnet.microsoft.com/download/dotnet/7.0)

2. **Clone the repository:** Clone this repository to your local machine using the following command:
   ```bash
   git clone https://github.com/zangassis/my-task-manager.git
   ```
3. **Build and Run:** Open a terminal or command prompt, navigate to the project's root directory, and execute the following commands:
   ```bash
   cd my-task-manager-backend
   dotnet restore
   dotnet build
   dotnet run
   ```

4. **API Endpoints:** Once the backend is running, you can access the API endpoints using a tool like Postman or any web browser. Here are a few example endpoints:
   - `GET /tasks`: Retrieve all tasks.
   - `GET /tasks/{id}`: Retrieve a specific task.
   - `POST /tasks`: Create a new task.
   - `PUT /tasks/{id}`: Update an existing task.
   - `DELETE /tasks/{id}`: Delete a task.

## Contributing 👥

Contributions are welcome! If you'd like to contribute to the My Task Manager backend, please follow these steps:

1. Fork the repository.

2. Create a new branch:
   ```bash
   git checkout -b my-new-feature
   ```

3. Make your changes and commit them:
   ```bash
   git commit -m 'Add some feature'
   ```

4. Push the changes to your forked repository:
   ```bash
   git push origin my-new-feature
   ```

5. Submit a pull request detailing your changes.

## License ⚖

This project is licensed under the [MIT License](LICENSE).

## Contact ✉️

If you have any questions or suggestions, feel free to reach out to the project maintainer at [assiszang@gmail.com](mailto:assiszang@gmail.com).

---
Happy task managing! 😊
