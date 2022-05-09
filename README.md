# Week - 4

# Homework 
## Business Management System
### Aim
- It is an application to be developed in order to follow the work in a workplace.
- The program will appeal to small or medium businesses
- It is expected that the jobs will be opened by the relevant persons and that the person who takes the job or is assigned the job will solve the job.
they want

## Homework Description
### Personnel Login
• Login to the system must be done by logging in.
• Login with e-mail and password is required.
• After logging in, a token must be generated with a system validity of 1 day.
- Personnel Registration
• Personnel Name (Mandatory)
• Staff Surname (Mandatory)
• E-Mail (Mandatory)
• Mobile Phone Number
• Department (Mandatory)
• Authority(Staff, Manager, Admin)(Mandatory)
Only Admin and users with Admin privileges should be able to enroll personnel.
After the personnel is registered, a 6-digit random password should be generated and sent to the relevant person's e-mail. The password corresponding to the password must be kept in the database. (You can choose the encryption algorithm you want. MD5, SHA1, etc…)
- Change Personnel Password
• Personnel should be able to change their password.
• Old password check is not done during password change.



### Creating New Demand
• Request title must be entered
• The department must be selected (the department where the job will go)
• Priority status should be selected (critical, urgent, etc…)
• Depending on the department, the subject should be selected (from the pre-prepared list)
• It should be possible to enter the start and end dates of the work (these dates should be optional)
•	Contents
Request creation should be done by entering the information.
### Job Listing
• It should be ensured that the jobs are listed according to the department the person works in.
- Request number
- Request header
- Priority Department
- Date of opening of the business
- Requesting person information should be listed
- Job Assignment
• The person will be able to choose a job from the job list sent to his/her department. Self-employment. Once a job is received, it will be blocked from being assigned to another person.

### Business Correspondence
• The person who opens and receives the job will be able to correspond over the job.
- Viewing the Detail of the Job
• Business Information
• Recipient information
• Correspondence on the job can be viewed
### Concepts to be Reinforced
- N-Tier Architecture design (presentation, service, entity, business layer, branch layer)
- OOP(class, object, interface, inheritance, multiple inheritance, constructor method, encapsulation)
- ORM-Entityframework
- Installing and using the Mapper structure
- Transaction management(UnitOfWork pattern)
- Repository,gereric repository pattern
- Generic method, generic class, generic interface
- Depency injeciton
- Distributing and using JWTToken
- REST API design
- Web Api Setup settings
- UML generation
- Creating a database by reading UML
- Database:Table, Column, Primary Key , Foreign Key, Unique key


## Author

Fatma Kurtuluş
