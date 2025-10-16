dnsResolver

# Prerequisites
You need to have the 2 DLL's in the same directory as dnsResolver.exe
DnsClient.dll
System.Buffers.dll

# Change Log
Added tab control
Window Position is now saved
Enter key now accepts the form and starts the query
Preset Google DNS servers (hard coded) 8.8.8.8 and 8.8.4.4
Added syntax error control for the domain that is to be queried
Added syntax error control for the DNS server used (must be in IP format)
Added ping test for the DNS server that is being queried (make sure it responds to ping)
Added port test for the DNS server that is being queried (make sure it's a valid DNS server, tested by looking for port 53)

# 2019.08.10
Added TXT records

# 2019.08.31
Updated regex for domain patern match to allow for TLD's like .US, .CO.JP or .JOBS

# 2021.09.25
Corrected the error control that checks the DNS server, should not crash if not the IP patern is not correct

# 2022.01.26
Added TTL for MX and TXT records