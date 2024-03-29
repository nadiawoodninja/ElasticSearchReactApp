# CourseProject


Project Proposal
CS 410 – Text Information Systems
N. Wood (nadiaw2)

# Search engine for indoor environment data using ElasticSearch

### Presentation Video
Part 1: https://uofi.box.com/s/a9p26mi8eym9i0n3ql8d83jke6ztzjbz

Part 2: https://uofi.box.com/s/gvsrrqsf9rpqbr48ha20slvg4m5eovky

### Final Report 
https://github.com/nadiawoodninja/CourseProject/blob/main/CS410ProjectFinalReport.pdf

### Demo App
https://cs410-env-search-app.uc.r.appspot.com/?size=n_20_n


### NetID: nadiaw2. Individual

## Abstract: 
In the age of sensors, devices and platforms collecting millions of datapoints every second, it comes necessary to be able to sift through all the data to develop insights efficiently Big data offers the solution for analyzing large amount of data and using the technique of Elasticsearch, access to data can be made faster. 

I will be creating a web front end in React to use ElasticSearch's App Search to search documents of environmental datapoints collected by sensors (indoor air, humidity, temp etc). Currently, it is difficult to search for data in a RDMS database and it takes significant time using traditional SQL queries. The project will take the data, transfer it to ElasticSearch platform. The front end written in React will allow users to search for data. Measurable outcomes are going to be the amount of effort it takes to search for data in traditional RDMS database vs. using ElasticSearch's platform.  The planned architecture is shown in Figure1: 
 
 ![alt text](https://github.com/nadiawoodninja/CourseProject/blob/main/architecture.png)
 
Figure 1






==============================


The estimated time to complete this project is about 30-40 hours. 
Tasks and time: 
1.	Determine how to set up, configure and deploy ElasticSearch on a cloud platform : 15 hours 
a.	The cloud platform determination will base on the cost difference between Azure, Google and AWS. 
2.	Development and deployment of Web application: 10 hours 
3.	Migration of SQL database to Elastic search server : 3 hours
4.	Test and measure outcomes: 4 hours


# PROGRESS REPORT

Progress Report
The estimated time to complete this project is about 30-40 hours. 

Tasks and time: 

### Task
Determine how to set up, configure and deploy ElasticSearch on a cloud platform : 
The cloud platform determination will base on the cost difference between Azure, Google and AWS. 
Created an account on Google and hosted ElasticSearch as a hosted service on ElasticCloud. 

### Hours
15 hours 

### Status
Completed


### Task
Migration of raw to json data to Elastic search server : 

### Hours
3 hours	
 
### Status
Completed

### Task
Created a data ingestion pipeline to read in a file which contains json per line and convert the file into an array of jsons. Then uploaded the data to ElasticSearch Cloud.
3.	Development and deployment of Web application: 
Creating a CRUD application in REACT using the API to communicate with the ElasticSearch Engine.


### Hours
10 hours	

### Status
Started. 
8 hours’ worth of work left. 



### Task
4.	Test and measure outcomes 	

### Hours
4 hours

### Status
Not started.



## Issues: 

Originally the plan was to develop a C#.NET application, but further research supported developing a front end using Node.js or React. I will be creating A CRUD (Create, read, update, delete) client using React. 
Understanding the ElasticSearch Stack takes a lot longer than expected. Had to make very conscious decisions what to implement. 

