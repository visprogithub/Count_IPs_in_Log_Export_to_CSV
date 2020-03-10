===========================================================================
    The Berndt Group -- Developer Candidate Preliminary Screening v1.8
===========================================================================

Write a program that creates a CSV report based on the provided log file.

The program should count the number of requests made by the IP addresses
contained in the log file.  The report should only count GET requests made
over the standard port used for HTTP and should exclude from the count all
requests made from IP's beginning with '207.114'.  The first field of the
report should contain the number of requests and the second field should
contain the IP address that made them.  The report should be ordered so
that IPs that made the most requests are listed first.  IPs that made the
same number of requests should be ordered amongst themselves with the IP
octets of greater values listed first.

Use the general purpose programming language in which you are most
proficient to solve the problem.

In your response, please provide the program source code, the CSV file
created by the program and how long it took for you to solve the problem.

NOTE: This screening exercise isn't representative of the type of work
developers usually do at TBG.  It's a simple test of programming ability.


The program should output a file called 'report.csv' containing the following:

8, "69.143.116.98"
3, "65.37.53.228"
1, "169.123.16.100"
1, "169.123.16.12"
1, "169.123.16.9"
1, "169.123.6.89"

