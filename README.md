# Fun With Array

A colorful console application that displays 2D integer arrays in multiple visualization modes with vibrant color coded output.

## Overview

**Fun With Array** is a .NET 8 console application that allows users to create and visualize 2D arrays of integers in four different display modes. The application uses the [Colorful.Console](https://github.com/tomakita/Colorful.Console) library to render arrays with color coded values and beautifully formatted layouts.

## Features

### Display Modes

1. **Standard View** (Mode 1)
   - Simple tabular display of all array elements
   - Clean and straightforward presentation

2. **Color-Coded (Even/Odd)** (Mode 2)
   - Even numbers displayed in **Blue**
   - Odd numbers displayed in **Red**
   - Helpful for quickly identifying number parity

3. **With Colorful Indices** (Mode 3)
   - Shows array indices in a color-coded format
   - Row indices in **Cyan**, column indices in **Magenta**
   - Useful for understanding array element positions

4. **Dotted Box Grid** (Mode 4)
   - Professional grid layout with borders
   - Color-coded by divisibility rules:
     - **Gold**: Divisible by 5
     - **Green**: Divisible by 3
     - **Blue**: Even (divisible by 2)
     - **Coral**: Odd
   - Centered values within cells

