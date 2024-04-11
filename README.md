**

**

# Employee management application | angular + .NET + sql server


**An application for basic management of company employees that includes terms of employment and an attendance log**
The company manager can change the company conditions, add a new employee, update an existing employee, add a csv file containing the employee's attendance logs.

*version 1.0.0*
___
**

# *API*

**

## **Entities:**

 - Company
 - Company terms
 - Employee
 - Employee terms
 - Employee bank account
 - Employee attendance journal
 - Position




## Routing

**Mapping routes for Company:**

 - Get company by id
GET https://api/Company/1

 - Update company by id
 PUT https://api/Company/1

 - Update user name and password of the company 
 PUT https://api/Company/1/entry-details

 - Update the company manager 
 PUT https://api/Company/1/manager

 - Delete the company from the DB
 DELETE https://api/Company/1
 
**

**Mapping routes for CompanyTerms:**

 - Get company terms by id
 GET https://api/CompanyTerms/1

 - Add new company terms
 POST https://api/CompanyTerms
 
 - Update exists company terms
PUT https://api/CompanyTerms/1

**

**Mapping routes for Employee:**

 - Get all employees by company id in csv format to download
 GET https://api/Employee/1/download
 
- Get all employees by company id
GET https://api/Employee/1

- Get employee by id
GET https://api/Employee/emp-id/1

- Add new employee to a company
POST https://api/Employee/1

- Update employee details
PUT https://api/Employee/1

- Update the employee positions
PUT https://api/Employee/1/positions

- Update status of employee (simulated deletion)
PUT https://api/Employee/delete/emp-id/1

**

**Mapping routes for EmployeeTerms:**

 - Get employee terms by id
 GET https://api/EmployeeTerms/1

 - Add new employee terms
 POST https://api/EmployeeTerms
 
 - Update employee terms by employee id
PUT https://api/EmployeeTerms/emp-id/1

**

**Mapping routes for BankAccount:**

 - Get employee bank account by id
 GET https://api/BankAccount/1

 - Add new bank account
 POST https://api/BankAccount
 
 - Update bank account
PUT https://api/BankAccount/1

 - Delete bank account
DELETE https://api/BankAccount/1

**

**Mapping routes for AttendanceJournal:**

 - Get employee attendances
 GET https://api/AttendanceJournal/emp-id/1

 - Add new attendace to employee by employee id
 POST https://api/AttendanceJournal/emp-id/1

 - Add list of attendaces
 POST https://api/AttendanceJournal
 
 **
 
 **Mapping routes for Position:**

 - Get all the positions
 GET https://api/Position

 - Add new position
 POST https://api/Position
 

**
---

***

# *client - Angular17*
The project was generated with  [Angular CLI](https://github.com/angular/angular-cli)  version 17.2.3.

## Development server

Run  `ng serve`  for a dev server. Navigate to  `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

***
opened by bracha goldberg  | https://github.com/BrachiGoldberg |  bracha.developer@gmail.com

**
