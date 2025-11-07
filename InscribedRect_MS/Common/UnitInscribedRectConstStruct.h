#pragma once

/**/
// --- --- --- CONSTANTS --- --- ---
/**/

/// <summary>
/// Minimum size of the slice in pixels
/// </summary>
const int MIN_SLICE_WIDTH = 5;
const int MIN_SLICE_HEIGHT = 5;

/**/
// --- --- --- STRUCTURES --- --- ---
/**/

/// <summary>
/// Types of the Slices in the detected Rectangle
/// </summary>
enum SLICE_TYPES {
	SLICE_ROWS_COLS = 1,
	SLICE_HEIGHT_WIDTH = 2
};