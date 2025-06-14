# 🛒 Order System - C# Console Application

This C# project simulates a basic order management system where you can register clients, create orders with multiple items, calculate totals, and display a complete summary.

---

## ✨ Features

- Client registration with name, email, and birth date.
- Creation of orders with status (Pending, Processing, Shipped, Delivered).
- Addition of multiple items to an order, controlling quantity and price.
- Calculation of each item's subtotal and the total order value.
- Formatted display of the order summary, including client and item details.

---

## 🛠️ Concepts Applied

- Classes and objects in C# (Client, Order, OrderItem, Product).
- Enumeration to represent order status.
- List manipulation to manage collections of items.
- Date and time with custom formatting.
- Overriding the `ToString()` method for formatted output.
- Console input and output handling.
- Type parsing and culture-aware formatting.

---

## 🚀 How to Use

1. Clone this repository.
2. Open it in your preferred C# environment (.NET CLI, Visual Studio, VS Code).
3. Build and run the program.
4. Enter the requested data via the console (client, order, items).
5. View the complete order summary printed on the console.

---

## 📚 Project Structure

- **Program.cs** – main application flow.
- **Entities/**
  - **Client.cs** – class representing the client.
  - **Order.cs** – class representing the order.
  - **OrderItem.cs** – class representing each item in the order.
  - **Product.cs** – class representing the product.
- **Entities/Enums/**
  - **OrderStatus.cs** – enumeration for the order status.

---
