# V-RU81K5CU83 - Virtual Rubik's Cube Using Kociemba Solver

A virtual Rubik's Cube implemented using the **Kociemba algorithm** for solving scrambled states. This project offers an interactive 3D simulation of a Rubik's Cube that you can scramble, manipulate manually, and solve. The solution is computed using the Kociemba two-phase algorithm, widely known for its efficiency in solving Rubik's cubes with minimal moves.

Deployment: This project is deployed using a WebGL server with Node.js alongside GitHub Pages for hosting the live demo.

**Heavily Inspired by:** [@Megalomobile](https://www.megalomobile.com/)

**[Click here for the Live Demo](https://mummanajagadeesh.github.io/v-cube-host/)**

## Features

- **Interactive 3D Cube**: Manipulate the cube by dragging and rotating different layers in 3D space.
- **Scramble & Solve**: Automatically scramble the cube or solve any configuration using the Kociemba algorithm.
- **Unity/Blender Simulation**: Visual simulations and demos showcasing the solution steps.
  
## Demo Videos

| [![Unity 3D Demo](https://img.youtube.com/vi/L4s2YYyi-70/0.jpg)](https://www.youtube.com/watch?v=L4s2YYyi-70) | [![Blender Solution Demo](https://img.youtube.com/vi/pQN5wu2dtTQ/0.jpg)](https://www.youtube.com/watch?v=pQN5wu2dtTQ) |
|:-------------------------------------------------------------------------------------------------------------:|:---------------------------------------------------------------------------------------------------------------------:|
| [Unity 3D Simulation](https://www.youtube.com/watch?v=L4s2YYyi-70)                                              | [Blender Simulation](https://www.youtube.com/watch?v=pQN5wu2dtTQ)                                                      |

## Controls

- **Right Click + Drag**: Rotate the entire cube in 3D space.
- **Left Click + Drag on Layers**: Rotate specific layers of the Rubik's Cube.
  
## Buttons

- **SCRAMBLE**: Randomly scrambles the Rubik's Cube.
- **SOLVE**: Solves the scrambled cube using the Kociemba solver. (Note: Initial solve may take some time to compute.)

## Installation & Setup

To run the project locally, follow these steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/Mummanajagadeesh/v-rubiks-cube.git
   cd v-rubiks-cube
   ```

2. Open the project in your preferred IDE or deploy it on a web hosting service.

3. To modify or extend the project, ensure you have:
   - A working knowledge of 3D engines such as Unity or Blender.
   - Familiarity with the Kociemba algorithm and basic Rubik’s Cube concepts.

## How the Solver Works

This project uses the **Kociemba two-phase algorithm**, which is an optimized approach for solving the Rubik's Cube in under 20 moves. The first phase reduces the problem to a manageable subset of configurations, and the second phase finds an optimal solution from that subset.

## Performance Notes

- The first time you run the solver, it may take longer due to the initial calculation of move tables.
- Subsequent solves will be faster as the tables are cached.

## License

This project is licensed under the MIT License.

Enjoy solving the cube! 🎲
