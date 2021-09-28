using System;

Console.Title = "YES";

string name;
string directions;
string action;
int coin = 10;
int loop = 1;
bool alive = true;



Console.WriteLine("What's your name?");
name = Console.ReadLine();

Console.WriteLine("Welcome " + name +" to your adventure!");

Console.WriteLine("You start of with 10 cold coins");

Console.WriteLine("Now choose your between the options!");

Console.WriteLine("Go right or left");


directions = Console.ReadLine();
directions = directions.ToLower();
    
if(directions == "left"){


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You have now arrived at Jolle's town");
    Console.ResetColor();

    Console.WriteLine("You found a shop, enter the shop or go straight");
    while(loop == 1){
    Console.WriteLine("Type: enter or forward");
    
    directions = Console.ReadLine();
    directions = directions.ToLower();

    if(directions == "enter"){

        Console.WriteLine("Buy a map (5 gold pieces) or exit");
        Console.WriteLine("Type: buy or exit");

        action = Console.ReadLine();
        action = action.ToLower();
        if(action == "buy"){
        
        coin = coin-5;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("-5 gold coins");
        Console.ResetColor();
        Console.WriteLine("You have now obtained the map and you have 5 gold pieces left");
        Console.WriteLine("To leave type exit");

        action = Console.ReadLine();
        action = action.ToLower();
        if(action == "exit"){
            Console.WriteLine("You leave the shop");
            Console.WriteLine("Now enter the shop agin or go straight");
            Console.WriteLine("Type: enter or forward");

            directions = directions.ToLower();

            if(directions == "forward"){
                loop = 1;
            }
        }
        else{
            Console.WriteLine("There is bad oxygen in the shop");
            Console.WriteLine("You stay and start to choke");
            alive = false;
        }
        }

    }
    else if(directions == "forward"){

       

        loop = 0;
        Console.WriteLine("You walk forward and fall into a dungeon, you hear a distant sound");
        Console.WriteLine("Suddently monsters appear behind you");

        Console.WriteLine("Fight or run");

        action = Console.ReadLine();
        action = action.ToLower();

        if(action == "fight"){
            
            alive = false;
            
        }
        else if(action == "run"){
            Console.WriteLine("You manage to run away");
            Console.WriteLine("But infront of you now there is a maze");

            if(coin > 5){
                 Console.WriteLine("You can't enter the maze without a map");
                 Console.WriteLine("The monster's catch up to you");
                 alive = false;
               
            } else if(coin == 5){
                Console.WriteLine("Do you want to use the map or not");
                Console.WriteLine("Yes or No");

                action = Console.ReadLine();
                action = action.ToLower();
                
                if(action == "yes"){
                    Console.WriteLine("8aaaaaaa8aaaa8888");
                    Console.WriteLine("8           8   8");
                    Console.WriteLine("8   aaaaa   8   8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8   aaaa8aaa8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8 y 8aaaaaaaa x 8");
                   

                    Console.WriteLine("The y marker is your position");
                    Console.WriteLine("The x marker is your goal");
                    Console.WriteLine("Hurry before the monster catch up to you");

                    Console.WriteLine("Now type a direction: ");
                    directions = Console.ReadLine();
                    directions = directions.ToLower();
                    
                    if(directions == "forward"){

                        Console.WriteLine("Alright keep going");

                    Console.WriteLine("8aaaaaaa8aaaa8888");
                    Console.WriteLine("8 y         8   8");
                    Console.WriteLine("8   aaaaa   8   8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8   aaaa8aaa8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8aaaaaaaa x 8");

                        Console.WriteLine("Now type a direction: ");
                         directions = Console.ReadLine();
                         directions = directions.ToLower();
                        if(directions == "right"){
                            Console.WriteLine("Well done");
                        
                    Console.WriteLine("8aaaaaaa8aaaa8888");
                    Console.WriteLine("8         y 8   8");
                    Console.WriteLine("8   aaaaa   8   8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8   aaaa8aaa8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8aaaaaaaa x 8");

                            Console.WriteLine("Now type a direction: ");
                             directions = Console.ReadLine();
                             directions = directions.ToLower();
                            if(directions == "right"){
                                Console.WriteLine("Good, now choose aagin");

                    Console.WriteLine("8aaaaaaa8aaaa8888");
                    Console.WriteLine("8           8   8");
                    Console.WriteLine("8   aaaaa   8   8");
                    Console.WriteLine("8   8     y     8");
                    Console.WriteLine("8   8   aaaa8aaa8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8aaaaaaaa x 8");

                                Console.WriteLine("Type a direction: ");
                                 directions = Console.ReadLine();
                                 directions = directions.ToLower();
                                if(directions == "right"){
                                    Console.WriteLine("Almost at the exit");

                    Console.WriteLine("8aaaaaaa8aaaa8888");
                    Console.WriteLine("8           8   8");
                    Console.WriteLine("8   aaaaa   8   8");
                    Console.WriteLine("8   8 y         8");
                    Console.WriteLine("8   8   aaaa8aaa8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8aaaaaaaa x 8");

                                    Console.WriteLine("Now type a direction: ");
                                     directions = Console.ReadLine();
                                     directions = directions.ToLower();

                                     if(directions == "left"){

                                         Console.WriteLine("So close");

                    Console.WriteLine("8aaaaaaa8aaaa8888");
                    Console.WriteLine("8           8   8");
                    Console.WriteLine("8   aaaaa   8   8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8   aaaa8aaa8");
                    Console.WriteLine("8   8 y         8");
                    Console.WriteLine("8   8aaaaaaaa x 8");

                                         Console.WriteLine("Now type a direction: ");
                                          directions = Console.ReadLine();
                                          directions = directions.ToLower();

                                          if(directions == "left"){

                                              Console.WriteLine("One more");

                    Console.WriteLine("8aaaaaaa8aaaa8888");
                    Console.WriteLine("8           8   8");
                    Console.WriteLine("8   aaaaa   8   8");
                    Console.WriteLine("8   8           8");
                    Console.WriteLine("8   8   aaaa8aaa8");
                    Console.WriteLine("8   8         y 8");
                    Console.WriteLine("8   8aaaaaaaa x 8");

                                              Console.WriteLine("Now type a direction: ");
                                              directions = Console.ReadLine();
                                              directions = directions.ToLower();
                                              
                                              if(directions == "right"){
                                                   Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                                  Console.WriteLine("Nicely done " +name);
                                                  Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                  Console.WriteLine("You have now completed the game by getting through the maze");
                                                  Console.WriteLine("Press any key to exit the game");
                                              }
                                          }else{alive = false;}
                                     }else{alive = false;}

                                }else{alive = false;}
                            }else if(directions == "left"){
                                Console.WriteLine("Too bad you went the wrong path.");
                                alive= false;
                            }else{alive = false;}
                        
                        }else{alive = false;}
                    }else{alive = false;}
                }
                else if(action == "no"){
                    Console.WriteLine("You decided not to use the map");
                    Console.WriteLine("Instead you hide behind a rock from the monsters");
                    Console.WriteLine("But suddently the monster appear infront of you");
                    alive = false;
                }else{
                    Console.WriteLine("Did not choose between yes or no");
                    alive = false;
                }
            }
        }
        else{
            Console.WriteLine("You did not run or fight.");
            alive = false;
        }
        }
        
    }
}

else if(directions == "right"){

    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Poor choice, you have arrived to the dumpster");
    Console.ResetColor();

    Console.WriteLine("Choose between go left or right");
    Console.WriteLine("Type: Left or Right");

    directions = Console.ReadLine();
    directions = directions.ToLower();

    if(directions == "right"){

        Console.WriteLine("Good choice");
        Console.WriteLine("Now choose left or right");
        if(directions == "left"){
            Console.WriteLine("By going to the dumpster you have gotten extremly unlucky");
            Console.WriteLine("By going left you fall down a trap");
            Console.WriteLine("You break your legs");
            alive = false;
        }
        else if(directions == "right"){
            Console.WriteLine("Wrong choice");
            alive = false;

        }
        else{
            alive = false;
        }

    }
    else if(directions == "left"){
        Console.WriteLine("You walk left and fall over a branch");
        Console.WriteLine("You ended up with a twisted ankle");
        Console.WriteLine("No one is around to help you get up.");
        Console.WriteLine("You starve");
        alive=false;
    }
    else{
        Console.WriteLine("Did not choose");
        Console.WriteLine("This lead to your demise");
        alive = false;
    }

}

else{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong choice, it was left or right idiot");
    Console.WriteLine("Press any key to exit the game"); 

}

if(alive == false){
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You died!");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit the game"); 
}



Console.ReadLine();