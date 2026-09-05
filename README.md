# Product & Parcel Management (GestionProduits)

A Windows desktop application for managing products and their incoming/outgoing parcels (deliveries), built with C# WinForms and SQL Server.

## Features
- Manage products (`Produit`): reference, designation, quantity in stock, purchase price
- Manage parcels (`Coli`): tracking number, delivery date, quantity, linked product
- CRUD screens for both products and parcels, plus a combined management screen (`GestionProduitMDC`)

## Tech Stack
- C# / .NET Framework 4.8 (WinForms)
- ADO.NET (`System.Data.SqlClient`) for data access
- Microsoft SQL Server / SQL Server Express

## Architecture
| Layer | Folder | Responsibility |
|---|---|---|
| Business objects | `metiers/` | `Produit`, `Coli` domain classes |
| Data access | `dao/` | Raw SQL against SQL Server |
| Controllers | `Controller/` | Bridges the UI to the DAO layer |
| UI | `GestionProduits/` | WinForms screens |

## Getting Started

### Prerequisites
- Visual Studio 2019+ with the ".NET desktop development" workload
- SQL Server or SQL Server Express

### Setup
1. Clone the repository.
2. Create a SQL Server database (e.g. `BDCommerciale`) with tables matching the `Produit` and `Coli` classes.
3. Update the connection string in [`dao/Connexionvente.cs`](dao/Connexionvente.cs) to point to **your own** SQL Server instance:
   ```csharp
   static string url = @"Server=YOUR_SERVER\SQLEXPRESS;Database=BDCommerciale;Trusted_Connection=True";
   ```
4. Open `GestionProduits.sln` in Visual Studio, restore/build the solution, and run.

## What to Fix Before Publishing
- [ ] **Hardcoded connection string** — move it into `App.config`
- [ ] **Class name typo**: `Coli` should almost certainly be `Colis` (French for "parcel") — worth a rename for correctness, though it will require updating references across `metiers/`, `dao/`, `Controller/`, and the UI
- [ ] **Folder casing is inconsistent**: `metiers/` and `dao/` are lowercase while `Controller/` and `GestionProduits/` are capitalized — pick one convention (PascalCase folders is the .NET norm)
- [ ] No screenshots or usage walkthrough yet

## License
Add a license of your choice (e.g. MIT) if you intend this to be public and reusable.
