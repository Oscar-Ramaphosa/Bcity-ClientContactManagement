# Client & Contact Management System

## Overview
This is an ASP.NET Core MVC application that manages Clients and Contacts using a many-to-many relationship.

The system allows users to:
- Create, edit, and delete clients
- Create, edit, and delete contacts
- Link contacts to clients
- Link client to contact
- Automatically generate unique client codes

---

## Features

### Client Code Generation
Each client is assigned a unique 6-character code:
- 3 uppercase alphabetic characters
- 3 numeric digits (001, 002, etc.)
- Example: FNB001, PRO002, ITA001

Rules:
- Multi-word names use first letters of each word (First National Bank → FNB)
- Single-word names use first 3 letters (Protea → PRO)
- Names with fewer than 3 letters are padded alphabetically (IT → ITA)

---

### Many-to-Many Relationship
Clients and Contacts are linked using a junction entity (ClientContact).

---

### Dashboard
Displays:
- Button to manage Clients
- Button to manage Contacts

---

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap
- C#

---

## Database Structure

Entities:
- Client
- Contact
- ClientContact (Junction Table)

---

## How to Run the Project

1. Clone the repository
2. Update the database connection string in `appsettings.json`
3. Run:
