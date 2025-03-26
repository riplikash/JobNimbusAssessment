# Overview

Simple coding assessment for JobNimbus application. Some basic string parsing with unit testing. And an alternate, 
more expandable solution, just for fun. Also, an excuse to show using git and readme's correctly. :) 

{non-existant professionalCat.gif}

## LeanBracketChecker

Simple, optimal solution for the problem as described. O(n) complexity.

## StackBracketChecker

Alternate solution that uses a stack instead of a counter. Still O(n) complexity, but uses slightly more memory. 
Useful in the case that you eventually want to track multiple bracketing types. 

For example, it could detect that `<html{>name}` might be invalid where `<html>{name}` or `<html {name}>` would be valid. 
