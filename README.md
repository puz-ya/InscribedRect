# InscribedRect inspection unit

Tries to find inscribed rectangle with maximum area in blob.

Input: 
  - Image: only mono filtered (after Extract Color) images can be input.
  - Parameter: max angle, will rotate found blob till met. Very time consuming! Takes SECONDS.
  Recomendation: set max_angle to less than 5 degrees.

Output: points & rectangle parameters (area, width, height, etc).

If output rectangle is (0;0)-(0;1)-(1;1), then it means no max angle was specified or other error occured.





## Platform
FH x64, based on firmware 6.51

## Details
Compiled with vc_redist v140: 14.40.33807.

Do not forget to add those .dll-s in /Release_x64/ folder
