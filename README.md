# SolutionCsharp9nov2023![repo9nov2023RungeKutta9nov2023](https://github.com/KrisBorre/SolutionCsharp9nov2023/assets/135237046/5453db06-db0d-4fad-8ba1-2ca579f0ca68)
Comparison between crude Runge-Kutta calculation and sophisticated Runge-Kutta calculation. The graph shows the numerical error of the calculation as a function of the stepsize for both, crude (orange) and sophisticated (blue). You read this graph from top-left to bottom-right. With a large stepsize the numerical error on the solution decreases when the stepsize is reduced. As the stepsize decreases the numerical error gets smaller until it reaches machine-epsilon using sophisticated Runge-Kutta.

When we use a Runge-Kutta algorithm - which I call crude Runge-Kutta - and continue to lower the stepsize in an attempt to improve the accuracy of the result, the accumulation of the numerical error starts to dominate over the solution, rendering our computational effort worthless. We can study this pathological behaviour when we use a system of differential equations that we can solve analytically. Here I pick Kepler's planetary motion. A planet moves around the Sun in an elliptic orbit. The equations of motion are ordinary differential equations and are numerically calculated using a Runge-Kutta method.

An Euler method or a higher order method will both have a similar accumulation error for a certain stepsize. We can correct for this accumulation of numerical errors and I call this method sophisticated Runge-Kutta.

Reference: Numerical methods for ODEs, Butcher (2008)
