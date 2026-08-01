# 🏪 Super Market Management System (SMMS)

A comprehensive desktop application for managing supermarket operations, built with **C# Windows Forms** and **SQL Server database**.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Project Structure](#project-structure)
- [Technology Stack](#technology-stack)
- [Prerequisites](#prerequisites)
- [Installation & Setup](#installation--setup)
- [Usage](#usage)
- [Database](#database)
- [File Descriptions](#file-descriptions)
- [User Roles](#user-roles)
- [License](#license)

---

## 📖 Overview

The Super Market Management System (SMMS) is a robust desktop application designed to streamline and manage daily operations in a supermarket environment. It provides role-based access control, inventory management, customer management, staff management, and order processing capabilities.

The application uses a **Windows Forms GUI** for user interaction and **SQL Server LocalDB** for data persistence, offering a reliable and secure solution for small to medium-sized retail operations.

---

## ✨ Features

### 🔐 Authentication & Authorization
- **User Login System**: Secure authentication with username and password verification
- **User Registration**: New user account creation with role assignment
- **Role-Based Access Control**: Different interfaces for Admin and Staff users
- **Session Management**: Track logged-in users throughout the application

### 📦 Inventory Management
- **Product Management**: Add, update, and delete products
- **Stock Tracking**: Monitor product availability and stock levels
- **Product Categories**: Organize products by categories
- **Product Details**: Track product ID, name, brand, price, and status
- **Image Support**: Store product images for visual identification

### 👥 Customer Management
- **Customer Records**: Maintain detailed customer information
- **Customer Database**: Search and filter customers
- **Purchase History**: Track customer transactions

### 👨‍💼 Staff Management
- **Staff Records**: Manage employee information
- **Staff Directory**: View and update staff details
- **Role Assignment**: Assign staff members to different roles

### 📊 Order & Sales Management
- **Order Processing**: Create and manage customer orders
- **Order History**: View past orders and transactions
- **Sales Dashboard**: Real-time sales metrics and analytics
- **Invoice Generation**: Generate detailed order invoices

### 📈 Dashboard & Analytics
- **Admin Dashboard**: Overview of key metrics and statistics
- **Sales Analytics**: Track sales performance and trends
- **Inventory Summary**: Quick view of stock status

---

## 🏗️ Project Structure

```
Repo38-SuperMarketMS/
├── Program.cs                      # Application entry point
├── Login.cs / Login.Designer.cs    # User authentication interface
├── Register.cs / Register.Designer.cs # User registration interface
├── FormLoad.cs / FormLoad.Designer.cs # Initial loading form
│
├── AdminMainForm.cs / Designer     # Admin dashboard interface
├── StaffMainForm.cs / Designer     # Staff dashboard interface
│
├── UC*.cs / Designer.cs / .resx    # User Control Components
│   ├── UCDashboard.cs              # Dashboard display component
│   ├── UCProducts.cs               # Product management component
│   ├── UCCategories.cs             # Category management component
│   ├── UCCustomers.cs              # Customer management component
│   ├── UCOrders.cs                 # Order management component
│   ├── UCStaff.cs                  # Staff management component
│   ├── UCPCard.cs                  # Product card display component
│
├── *Data.cs                        # Data Access Layer (DAL)
│   ├── ProdsData.cs                # Product database operations
│   ├── CategoriesData.cs           # Category database operations
│   ├── CustomersData.cs            # Customer database operations
│   ├── UsersData.cs                # User account database operations
│   ├── OrdersData.cs               # Order database operations
│   └── SuperMarketData.cs          # Global application data
│
├── SuperMarket.mdf                 # SQL Server LocalDB database file
├── SuperMarket_log.ldf             # Database log file
├── App.config                      # Application configuration
├── SuperMarketMS.csproj            # Project file
├── packages.config                 # NuGet dependencies
└── Images/                         # Product images directory
```

---

## 💻 Technology Stack

| Component | Technology |
|-----------|-----------|
| **Language** | C# (.NET Framework) |
| **UI Framework** | Windows Forms (WinForms) |
| **Database** | SQL Server LocalDB |
| **Database Access** | ADO.NET (SqlClient) |
| **IDE** | Visual Studio (recommended) |
| **.NET Version** | .NET Framework 4.x |

---

## 📋 Prerequisites

Before setting up the project, ensure you have:

1. **Visual Studio** (2019 or later recommended)
   - With "Desktop development with C#" workload installed
   
2. **.NET Framework 4.5+** or higher installed

3. **SQL Server LocalDB** 
   - Installed as part of Visual Studio installation
   - Or separately from SQL Server Express

4. **Administrator Access** on your development machine

---

## 🚀 Installation & Setup

### Step 1: Clone or Download the Repository

```bash
git clone https://github.com/GayathriHubb/Repo38-SuperMarketMS.git
cd Repo38-SuperMarketMS
```

### Step 2: Open in Visual Studio

1. Launch Visual Studio
2. Click **File** → **Open** → **Project/Solution**
3. Navigate to the repository folder
4. Select `SuperMarketMS.csproj` and click **Open**

### Step 3: Configure Database Connection

The application uses SQL Server LocalDB. Update the connection string in data access files if needed:

**Default connection string** (in `ProdsData.cs` and similar files):
```csharp
"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CSharp\\WinFormsNetFmwk1\\SuperMarketMS\\SuperMarket.mdf;Integrated Security=True"
```

**Update the path** to match your local directory:
```csharp
// Replace D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\ with your actual project path
```

### Step 4: Restore NuGet Packages

1. Right-click on the project → **Manage NuGet Packages**
2. Click **Restore** to install all dependencies

### Step 5: Build and Run

1. Press **Ctrl + Shift + B** to build the solution
2. Press **F5** to run the application
3. The FormLoad splash screen will appear, followed by the Login dialog

---

## 📖 Usage

### Initial Setup

1. **First Run**: The application starts with a login screen
2. **Register Account**: Click "Register" to create a new user account
   - Enter username, password, and confirm password
   - Select user role (Admin or Staff)
3. **Login**: Use your credentials to login

### Admin Features

As an **Admin**, you have access to:
- **Dashboard**: View overall system statistics
- **Products**: Add, edit, delete product inventory
- **Categories**: Manage product categories
- **Customers**: View and manage customer database
- **Orders**: Monitor and manage customer orders
- **Staff**: Manage employee records and access

### Staff Features

As a **Staff member**, you have access to:
- **Dashboard**: View sales metrics (limited)
- **Products**: View and search available products
- **Orders**: Process customer orders and generate invoices
- **Customers**: Access customer information

---

## 🗄️ Database

### Database Structure

The application uses **SQL Server LocalDB** with the following main tables:

#### **Users Table**
- UserID (Primary Key)
- Username (Unique)
- Password (Hashed)
- UserRole (Admin/Staff)
- DateCreated
- Status

#### **Products Table**
- ProdId (Product ID)
- ProdName (Product Name)
- CategoryName (Product Category)
- Brand (Manufacturer/Brand)
- ProdStock (Stock Quantity)
- ProdPrice (Unit Price)
- ProdStatus (Available/Discontinued)
- ImagePath (Product Image Path)
- DateInsert (Creation Date)
- DateUpdate (Last Updated Date)
- DateDelete (Soft Delete Date)

#### **Categories Table**
- CategoryId (Primary Key)
- CategoryName
- Description
- DateInsert

#### **Customers Table**
- CustomerId (Primary Key)
- CustomerName
- ContactNumber
- Email
- Address
- DateJoined

#### **Orders Table**
- OrderId (Primary Key)
- CustomerId (Foreign Key)
- OrderDate
- OrderStatus
- TotalAmount

### Database File Location

The database file `SuperMarket.mdf` is included in the repository. Make sure the path in the connection string points to the correct location.

---

## 📁 File Descriptions

### Forms & UI Components

| File | Purpose |
|------|---------|
| `Program.cs` | Application entry point; initializes FormLoad |
| `FormLoad.cs` | Splash screen / Loading form displayed at startup |
| `Login.cs` | Authentication form; validates user credentials |
| `Register.cs` | User registration form; creates new accounts |
| `AdminMainForm.cs` | Main dashboard for Administrator users |
| `StaffMainForm.cs` | Main dashboard for Staff users |

### User Control Components (UC*.cs)

| Component | Purpose |
|-----------|---------|
| `UCDashboard.cs` | Displays dashboard with system overview |
| `UCProducts.cs` | Product inventory management interface |
| `UCCategories.cs` | Product category management interface |
| `UCCustomers.cs` | Customer record management interface |
| `UCOrders.cs` | Order processing and invoice generation |
| `UCStaff.cs` | Staff record management interface |
| `UCPCard.cs` | Product card display component for UI |

### Data Access Layer (DAL)

| File | Purpose |
|------|---------|
| `ProdsData.cs` | Product database CRUD operations |
| `CategoriesData.cs` | Category database CRUD operations |
| `CustomersData.cs` | Customer database CRUD operations |
| `UsersData.cs` | User account database operations |
| `OrdersData.cs` | Order database operations |
| `SuperMarketData.cs` | Global application data (e.g., current username) |

### Configuration Files

| File | Purpose |
|------|---------|
| `App.config` | Application configuration settings |
| `packages.config` | NuGet package dependencies |
| `SuperMarketMS.csproj` | Visual Studio project file |
| `SuperMarketMS.csproj.user` | User-specific project settings |

---

## 👤 User Roles

### Admin Role
- Full system access
- Manage all products, categories, and inventory
- Manage customer and staff records
- View analytics and reports
- System configuration and settings

### Staff Role
- Limited system access
- View product inventory
- Process customer orders
- Access customer information (for order processing)
- Generate invoices

---

## 🔒 Security Notes

⚠️ **Important**: This is a demonstration project. For production use:

1. **Password Hashing**: Implement proper password hashing (e.g., bcrypt)
2. **SQL Injection Prevention**: Use parameterized queries (already partially implemented)
3. **Connection String**: Move connection strings to secure configuration
4. **Access Control**: Implement more granular role-based permissions
5. **Audit Logging**: Add logging for sensitive operations
6. **Data Encryption**: Encrypt sensitive data at rest

---

## 🤝 Contributing

Contributions are welcome! Please:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit changes (`git commit -m 'Add YourFeature'`)
4. Push to branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

---

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

---

## 📞 Support

For issues, bugs, or feature requests, please open an issue on GitHub or contact the project maintainer.

---

## 📝 Version History

- **v1.0** (2026-01-16): Initial release with core functionality
  - User authentication and registration
  - Product and inventory management
  - Customer and staff management
  - Order processing
  - Dashboard and analytics

---

## 🎯 Future Enhancements

Potential improvements for future versions:

- [ ] Web-based dashboard for remote access
- [ ] Advanced reporting and analytics
- [ ] Barcode scanning for products
- [ ] Multi-location support
- [ ] Automated email notifications
- [ ] Mobile app for staff
- [ ] Payment gateway integration
- [ ] Backup and recovery features
- [ ] User activity audit logs
- [ ] Multi-language support

---

## 🙏 Acknowledgments

- Built with C# and Windows Forms
- Powered by SQL Server LocalDB
- Developed as an educational project

---

**Last Updated**: August 1, 2026

**Project Owner**: [GayathriHubb](https://github.com/GayathriHubb)

---

*For more information about the project structure and implementation details, please refer to individual file comments and code documentation.*
