#pragma once

// Simulation flag status (for debug)
const int SIMULATOR_FLAG = 0;

//Simulation delay before we attach to process (ProcItem_UI or Fz-CoreRA) for Debug
const int SIMULATOR_THREAD_SLEEP = 5000;

//CHECK_WHERE_WE_RUN == 2 in Release mode, other number in Sim
const int CHECK_WHERE_WE_RUN = 2;

//Default image size (0.3 mpx)
const int DEF_SIZE_X = 640;
const int DEF_SIZE_Y = 480;

/// <summary>
/// Assuming FH-SM21R (x4) by OX, 5544x4 = 22176 px
/// Assuming FS-B4KU7 (x4) by OX, 4096x4 = 16384 px
/// Assuming FS-B8KU7 (x4) by OX, 8192x4 = 32768 px
/// </summary>
const int MAX_OX = 32768;
const int MAX_IMG_SIZE_X = 32768;

/// <summary>
/// Assuming FH-SM21R (x4) by OY, 3692x4 = 14768 px
/// Assuming FS-B8KU7 (x4) by OX, 8192x4 = 32768 px
/// </summary>
const int MAX_OY = 32768;
const int MAX_IMG_SIZE_Y = 32768;

//math const
const double EPS = 0.000001; //to compare doubles
const double EPS_INT = 1;	//to compare ints

const int SIZE16 = 16;		//replace num with searchable const 16
const int SIZE32 = 32;		//replace num with searchable const 32
const int SIZE64 = 64;		//replace num with searchable const 64
const int SIZE128 = 128;	//replace num with searchable const 128
const int SIZE256 = 256;	//replace num with searchable const 256
const int SIZE512 = 512;	//replace num with searchable const 512
const int SIZE1024 = 1024;	//replace num with searchable const 1024
const int SIZE2048 = 2048;	//replace num with searchable const 2048
const int SIZE4096 = 4096;	//replace num with searchable const 4096
const int SIZE8192 = 8192;	//replace num with searchable const 8192
