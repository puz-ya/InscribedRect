#pragma once

/// <summary>
/// Distance between 2 int points
/// </summary>
/// <param name="x1"></param>
/// <param name="x2"></param>
/// <param name="y1"></param>
/// <param name="y2"></param>
/// <returns></returns>
inline double Dist(int x1, int x2, int y1, int y2)
{
    return sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

inline double DistNoRoot(int x1, int x2, int y1, int y2)
{
    return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
}

/// <summary>
/// Distance between 2 double points
/// </summary>
/// <param name="x1"></param>
/// <param name="x2"></param>
/// <param name="y1"></param>
/// <param name="y2"></param>
/// <returns></returns>
inline double Dist(double x1, double x2, double y1, double y2)
{
    return sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

inline double DistNoRoot(double x1, double x2, double y1, double y2)
{
    return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
}

/// <summary>
/// Distance between 2 float points
/// </summary>
/// <param name="x1"></param>
/// <param name="x2"></param>
/// <param name="y1"></param>
/// <param name="y2"></param>
/// <returns></returns>
inline float Dist(float x1, float x2, float y1, float y2)
{
    return sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

inline float DistNoRoot(float x1, float x2, float y1, float y2)
{
    return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
}