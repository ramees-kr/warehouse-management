# Warehouse Management System

Welcome to the Warehouse Management System project! This system is designed to streamline warehouse operations, manage inventory, and facilitate user authentication for efficient warehouse management.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The Warehouse Management System is a desktop application built using .NET Framework and Windows Forms. It provides a user-friendly interface for warehouse staff to manage inventory, process orders, and track stock movements.

## Features

- User authentication to secure access to the system.
- Inventory management to add, update, and delete products in the warehouse.
- Order processing, including order creation, picking, packing, and shipping.
- Dashboard for real-time monitoring of warehouse operations.

## Tech Stack

- **.NET Framework**: A software framework for building Windows desktop applications.
- **Entity Framework**: An ORM (Object-Relational Mapping) framework for data access and manipulation.
- **C#**: A programming language used for application logic and backend services.
- **Windows Forms (WinForms)**: A UI framework for creating desktop applications with a graphical user interface.
- **Microsoft.Extensions.DependencyInjection**: A library for implementing dependency injection in .NET applications.
- **SQL Server**: The database management system used for storing and managing warehouse data.

## Installation

1. Clone this repository to your local machine.
2. Run the SQL script provided in the `database` folder to create the database schema.
3. (Optional) Download the dataset from Kaggle (link) to populate the products table with real-world data.

## Usage

1. Build the solution in Visual Studio to resolve dependencies and compile the application.
2. Run the application by starting the `warehouse_management` project.
3. Use the login form to authenticate and access the system.
4. Explore the different features such as inventory management, order processing, and dashboard monitoring.

## Contributing

Contributions to the Warehouse Management System project are welcome! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/new-feature`).
3. Make your changes and commit them (`git commit -am 'Add new feature'`).
4. Push your changes to the branch (`git push origin feature/new-feature`).
5. Create a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
