# Create Branch
```
https://{{localhost}}/api/branches/create
{
	"Name": "Test Branch One",
	"Location": "Anuradhapura Main",
}
```

## Result:
{{branch id}}

------------------------------------------

# List All Brahces
``` https://{{localhost}}/api/branches/ ```

## Result:
```
[
    {
        "id": 1,
        "name": "Test Branch One",
        "location": "Anuradhapura Main",
        "active": false,
        "users": [],
        "students": []
    }
]
```

# Create user
```
https://{{localhost}}/api/users/create
{
	"FirstName": "Steewan",
	"LastName": "Rogers",
	"Email": "captain@avghead.com",
	"Password": "bucky"
	"Role": 1,
	"AddressLine1": "235 av",
	"AddressLine2": "1st lane",
	"AddressLine2": "USA",
	"BranchID": 1,
}
```

## Result
{{user id}}

# Update user
```
https://{{localhost}}/api/users/create
{
	"Id": 1, 
	"FirstName": "Steewan",
	"LastName": "Rogers",
	"Email": "captain@avghead.com",
	"Password": "bucky"
	"Role": 1,
	"AddressLine1": "235 av",
	"AddressLine2": "1st lane",
	"AddressLine2": "USA",
	"BranchID": 1,
}
```

# Login
```
https://{{localhost}}/api/users/login
{
	"Username": "captain@avghead.com",
	"Password": "bucky",
	"BranchID": 1,
}
```

## Result:
```
{
    "jwt": "JWT",
    "userID": 1,
    "userRole": "1",
    "branchId": 1
}
```

# Get Student
```
https://{{localhost}}/api/students
```

## Result:
```
[
    {
        "id": 1,
        "indexNumber": "223ST29",
        "admissionDate": "2019-01-01T00:00:00",
        "admissionFree": 1000,
        "firstName": "Bruce",
        "secondName": null,
        "lastName": "Banner",
        "dob": "1992-08-22T00:00:00",
        "addressLine1": "234, av st",
        "addressLine2": null,
        "addressLine3": "USA",
        "school": "Av School",
        "grade": "1",
        "class": "D",
        "photo": "223ST29",
        "registerDate": "0001-01-01T00:00:00",
        "note": "",
        "status": false
    }
]
```

# Create Student
```
https://{{localhost}}/api/students
{
	"Id": 1,
	"IndexNumber": "223ST29",
	"AdmissionDate": "2019-01-01",
	"BatchNo": "",
	"AdmissionFree": 1000,
	"FirstName": "Bruce",
	"LastName": "Banner",
	"DOB": "1992-08-22",
	"AddressLine1": "234, av st",
	"AddressLine3": "USA",
	"School": "Av School",
	"Grade": "1",
	"Class": "D",
	"RegistrationDate": "2000-01-01",
	"Note": "",
	"Photo": "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",
}
```
## Result
{{student id}}


# Get Student Image
```
https://{{localhost}}/api/students/image/223ST29
<img src="{{https://{{localhost}}/api/students/image/223ST29}}" size="200" />
```

# Parents
## Get
``` https://{{localhost}}/api/parents/ ```

## Create \ Update
```
https://{{localhost}}/api/parents/create
{
	"FatherName" : "sample data",
	"FatherOccupation" : "sample data",
	"FatherOfficeAddress" : "sample data",
	"FatherMobileNumber" : "sample data",
	"MotherName" : "sample data",
	"MotherOccupation" : "sample data",
	"MotherOfficeAddress" : "sample data",
	"MotherMobileNumber" : "sample data",
	"AddressLine1" : "sample data",
	"AddressLine2" : "sample data",
	"City" : "sample data",
	"LandLineNumber" : "sample data",
	"SMSAlertNumber" : "sample data"
}
```