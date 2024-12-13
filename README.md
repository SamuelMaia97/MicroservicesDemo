# README

### **Project Overview**

This project is a microservices-based architecture using Docker, ASP.NET Core, and SQL Server. It includes the following services:

-   **OrderService**: Manages orders and interacts with the database.
-   **ProductService**: Manages product data, which can be used by `OrderService`.
-   **API Gateway**: Acts as a reverse proxy to route requests to the respective services.
-   **SQL Server**: Stores data for both services.

### **Technologies Used**

-   **ASP.NET Core** (Web API)
-   **Entity Framework Core**
-   **SQL Server** (Dockerized)
-   **Docker & Docker Compose** for containerization
-   **Swagger** for API documentation and testing

* * * * *

### **Prerequisites**

-   Docker and Docker Compose installed on your local machine.
-   Visual Studio or VS Code for code editing (optional).
-   SQL Server Management Studio (SSMS) or Azure Data Studio for inspecting databases.

* * * * *

### **Setting Up the Project**

1.  **Clone the Repository**: Clone the repository to your local machine:

    ```bash
    git clone https://github.com/your-repo/microservices-demo.git
    cd microservices-demo
    ```

2.  **Build and Run the Containers**: Build and start the Docker containers with the following command:

    ```bash
    docker-compose up --build
    ```

    This will start the following services:

    -   **SQL Server** (listening on port 1433)
    -   **OrderService** (listening on port 5002)
    -   **ProductService** (listening on port 5001)
    -   **API Gateway** (listening on port 5000)

* * * * *

### **Accessing the Services**

-   **Swagger for OrderService**: Access the Swagger UI for `OrderService` at:

    ```bash
    http://localhost:5002/swagger
    ```

-   **Swagger for ProductService**: Access the Swagger UI for `ProductService` at:

    ```bash
    http://localhost:5001/swagger
    ```

-   **API Gateway**: The API Gateway routes requests to the appropriate service. Example:

    ```bash
    http://localhost:5000/api/orders
    ```

* * * * *

### **Testing the API**

Use **Postman** to interact with the APIs. Here are example requests:

-   **Get Orders** (from `OrderService`):

    In Postman, create a **GET** request to:

    ```bash
    http://localhost:5002/api/orders
    ```

    Set the **Accept** header to `application/json`.

-   **Get Products** (from `ProductService`):

    In Postman, create a **GET** request to:

    ```bash
    http://localhost:5001/api/products
    ```

    Set the **Accept** header to `application/json`.

-   **Get Orders via API Gateway**:

    In Postman, create a **GET** request to:

    ```bash
    http://localhost:5000/api/orders
    ```

    Set the **Accept** header to `application/json`.

* * * * *

### **Verifying the Database**

1.  **Connect to SQL Server** using SSMS or Azure Data Studio:

    -   **Server**: `localhost,1433`
    -   **Username**: `sa`
    -   **Password**: `Your_password123`

2.  **Check the `OrderServiceDB` Database** for tables and data.

* * * * *

### **Troubleshooting**

-   **SSL/TLS Errors**: If you encounter SSL errors, ensure that the `TrustServerCertificate=True` flag is set in your connection string.
-   **Database Connection Errors**: Check if the SQL Server container is up and running by inspecting logs:

    ```bash
    docker logs sqlserver
    ```

* * * * *

### **Conclusion**

This project demonstrates a basic microservices architecture with Docker, ASP.NET Core, and SQL Server. 
