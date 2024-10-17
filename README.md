# Store App
The Store App is a comprehensive web application designed to manage customer orders, and facilitate online shopping. It incorporates advanced features like role-based authorization, real-time notifications, and secure payment processing, ensuring an efficient and seamless user experience.

## Key Features
- **CRUD Operations**: Effortlessly create, read, update, and delete products, orders, and users.
- **Filtering, Sorting, Searching, and Pagination**: Optimized performance with advanced query capabilities for easy product discovery.
- **Authentication and Authorization**: Secure user authentication with cookies, along with role-based authorization for managing access.
- **Real-Time Notifications**: Receive live updates and notifications using SignalR.
- **Payment Integration**: Seamlessly process payments through Stripe.
- **Unit of Work Pattern**: Ensures efficient transaction management across multiple operations.
- **Specification Pattern**: Implements reusable and flexible business logic for querying and data access.
- **Redis for Cart Management**: Ensures fast and scalable storage for user carts.

## Technologies Used
- **.NET 8**: Backend built with .NET 8 APIs, providing scalability and performance.
- **Entity Framework**: Used for data access and management, simplifying database interactions.
- **Redis**: Leveraged for fast in-memory storage of shopping cart data.
- **SignalR**: Employed to implement real-time notifications and updates.
- **Stripe**: Integrated for secure payment processing.
- **ASP.NET Core MVC**: Used to structure the application, ensuring a clean separation of concerns.
- **SQL / NoSQL Databases**: For efficient and secure database management.
- **Bootstrap**: Ensures a responsive and visually appealing design for both mobile and desktop users.
- **Clean Architecture**: Separation of concerns to improve scalability, modularity, and maintainability.

## Additional Technical Highlights
- **Repository Pattern**: Provides a flexible and reusable way to manage data access.
- **Unit of Work Pattern**: Ensures that changes to the database are handled within a single transaction for consistency.
- **Dependency Injection**: Enhances the modularity and maintainability of the application.
- **Comprehensive Error Handling**: Ensures smooth operation and provides useful feedback on errors.
- **Cross-Origin Resource Sharing (CORS)**: Configured for secure communication between the client and the server.

## Installation and Setup
1. Clone the repository:
    ```bash
    git clone https://github.com/Ahmed-Refa3e/Store-App.git
    ```
2. Navigate to the project directory:
    ```bash
    cd Store-App
    ```
3. Install the dependencies:
    ```bash
    dotnet restore
    ```
4. Set up the database and environment variables:
    ```bash
    # Create a .env file and add your database credentials
    DATABASE_URL=your_database_url
    REDIS_URL=your_redis_url
    STRIPE_SECRET_KEY=your_stripe_secret_key
    ```
5. Run the application:
    ```bash
    dotnet run
    ```

## Usage
- Access the application through your web browser at `http://refaie.runasp.net/swagger/index.html`.
- Use the interface to manage products, orders, and users, along with cart functionality.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgements
Special thanks to the open-source community for providing the tools and frameworks used in this project.


---


<div align="left">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="40" alt="csharp logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" height="40" alt="dotnetcore logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/git/git-original.svg" height="40" alt="git logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg" height="40" alt="visualstudio logo"  />
  <img width="12" />
</div>

###
