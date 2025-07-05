# 🛒 E-Commerce System - Fawry Rise Journey Challenge

This project is part of the **Fawry Rise Journey Summer Internship Challenge**.

It simulates a simple **e-commerce system** using Object-Oriented Programming principles, with product types, customer interaction, and checkout logic.

---

## 🚀 Features

- Define different product types:
  - Expirable (e.g. Cheese, Biscuits)
  - Shippable (e.g. TV, Cheese)
  - Virtual/Non-shippable (e.g. Mobile Scratch Cards)

- Add products to a cart with a specific quantity.
- Prevent adding quantity more than available stock.
- Checkout process prints:
  - Subtotal (sum of item prices)
  - Shipping fees (based on weight × 5)
  - Total amount
  - Customer's remaining balance

- Handle errors for:
  - Empty cart
  - Insufficient customer balance

---

## 🧠 OOP Principles Used

- **Abstraction & Inheritance**:
  - `Product` is an abstract base class.
  - Inherited by concrete product types like `Cheese`, `Tv`, `ScratchCard`, `Biscuit`.

- **Interfaces**:
  - `IShippable` → defines `Weight`
  - `IExpirable` → defines `ExpiryDate`

- **Encapsulation**:
  - Cart logic and validations are encapsulated in `Cart` class.
  - Checkout logic in `OrderService`.

---

## 📦 Project Structure

