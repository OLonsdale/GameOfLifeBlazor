# GameOfLife

## Rules

- Any live cell with fewer than two live neighbours dies, as if by underpopulation.

- Any live cell with two or three live neighbours lives on to the next generation.

- Any live cell with more than three live neighbours dies, as if by overpopulation.

- Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

## Implementation

So turns out blazor really sucks for this, the rendering is painfully slow. (using blazor wasm, dotnet 8)

I've optimised it as best I can, going from having a cell class., then a cell struct, then finally down to just a 2d array of bools to try and reduce overhead.

Turns out doing like @onclick="() => ToggleCell(x,y)" or having any lambda at all triples the rendering speed, so I've had to do some screwy stuff with JS interop to get the event that way.

Does make me wonder why I didn't just do the whole thing in JS...

## Settings

It's got all the basics, play/pause, step one generation, clear the grid, randomise the grid, adjust grid size, show grid lines, and wrap the edges of the grid.

It also displays the generation, calculation time and render time.

## Planned improvements

- Disable the event handlers while in "play" mode, should boost rendering dramatically. (it did, down to ~20ms for an empty 50x100 grid, down from 30-40 with the JS event handler, and 50 with the lambda

- Fix grid toggle needing multiple clicks to change

- Maybe fix "living cells" counter? Adds a stupid amount of overhead. Could calculate in the main "step" loop?

- Custom colours

- Save/Load state
  
- Could do with loads of restructuring and UI work, but quick and simple was the aim with this project. Was done mostly within 24 hours.