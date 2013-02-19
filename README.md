EmptyShredDetector
==================

detection of empty shreds


This program contains a function "isEmpty" that takes in a Bitmap of a shred and returns a boolean value to indicate
if the shred is empty.


The function is very simple.  It first finds the Histogram of the image.  Then it goes through the histogram and Tally's
up the zeros that it encounters.  Shreds that are empty tend to have way more zeros than shreds with text on them.  This
is becuase text fills up the color range (0-100) which are the color values that dark text has.  

The threshold of 300 zeroes is based on experimental evidence only and it needs to be tested against a greater amount of
shreds
