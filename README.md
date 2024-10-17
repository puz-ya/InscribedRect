# InscribedRect inspection unit

Tries to find inscribed rectangle with maximum area in blob.

Input: 
  - Image: only mono filtered (after Extract Color) images can be input.
  - Parameter: max angle, will rotate found blob till angle limit is met. Very time consuming! Takes SECONDS.
  Recomendation: set max_angle slider value to less than 5 degrees (included).

Output: points & rectangle parameters (area, width, height, etc).

In case of error, output rectangle will be (0;0)-(0;1)-(1;1).


## Platform
FH x64, based on firmware 6.51

## Details
Compiled with VS2022, vc_redist v140: 14.40.33807.

Uses OpenCV 4.5.2. Usage of OpenCV 4.10 is also possible.

Do not forget to add those .dll-s in your /Release_x64/ folder.
They are NOT included here.

**Any help with speeding this up appreciated!**