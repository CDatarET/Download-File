# Download-File
CodeChef Difficulty 1147 Problem. 

# Internet Data Charges Calculator

Chef has recently got a broadband internet connection. His history of internet data usage is provided as below.

During the first `T1` minutes, the internet data used was `D1` MBs per minute, and during the next `T2` minutes, it was `D2` MBs per minute, and so on till during the last `TN` minutes it was `DN` MBs per minute.

The internet provider charges Chef **1 dollar for every 1 MB** of data used, **except for the first `K` minutes**, when the internet data is free as part of the plan provided to Chef.

## Problem Statement

Calculate the **total amount (in dollars)** Chef has to pay to the internet provider.

---

## Input

- The first line of the input contains a single integer `TC`, the number of test cases.
- For each test case:
  - The first line contains two space-separated integers `N` and `K`:
    - `N`: Number of usage segments
    - `K`: Number of free minutes
  - The next `N` lines each contain two space-separated integers `Ti` and `Di`:
    - `Ti`: Duration of the i-th segment in minutes
    - `Di`: Data usage rate (MBs per minute) during the i-th segment

---

## Output

- For each test case, print a single integer — the amount Chef has to pay in dollars.

---
