# Battleship

 Technical challenge

### Structure

The project is structure to enable extensibility and ease of development. The structure is as follows:

#### Battleship.csproj

#### Ship
- Ship takes startingpoint, orientation,length from console 
- GetStartingPoint returns starting point as Point, 
- GetOrientation returns orientation as ShipOrientation.Horizontal or ShipOrientation.Vertical
- GetLength returns Length as ineteger
- SetPosition sets position of ship based on Length it check for orientations and saves Points[] as position.

#### Attack
- Takes HitPosition from console and save them as new point.

#### ShipOrientation
- Stores ship orientation as enum vertical and Horizontal 


#### Program

- Places the ship on Board by setting up board coordinates on which ship is placed to value 9.
- Evaluate Hit or Miss by setting up board to -1 if the hit is sucessfull and setting up board coordinates to 1 if it is a fail.

#### Entire working 

- Welcome to the Board!, Place the ship by  Entering starting point-  0,0 stands for x and y coordinates, orientation - Horizontal or vertical, Length - 2
- Reading values of starting point, orientation, length.
- Sending starting point, orientation, length to ship.
- Sets the position Point[] of the ship, example for values( 0,0 Horizontal 2) it stores position as new Point { X = 0, Y = 0 }, new Point { X = 0, Y = 1 } .
- Places the ship on the Board for ship postion[0,0] and ship position [0,1] it gives it value 9. ship position coordinates will have 9 value on board.
- If Ship is placed on given hit coordinates it will return Hit else miss.
- For already provided hit coordinates it return "Coordiantes Already hit" same for miss.
- 
#### BattleshipTest.csproj
- ShipParametersTest() tests for GetStartingPoint, GetOrientation, GetOrientation methods in Ship.
