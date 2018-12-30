##sets up the sense hat module for python.
from sense_hat import SenseHat 
import random #uses the random module used when generating a new value .
import time #uses the time module
sense = SenseHat()#sets a variable for using the sensehat's API.
random.seed()
GameTime = 3.0#sets the game time to 3.0 seconds.
Score = 0
Randoms = [0,90,180,270]#lists all angles.
Angular = 0
current = 0
prev = 0
lives = 3
RandomAngle = random.choice(Randoms)#chooses a random angle from the list.
#used to set the arrow to a certain color.
green = (0, 255, 0)
yellow = (255,255,0)
white = (255, 255, 255)
red =(255, 0, 0)
nothing = (0,0,0)
w = white
y = yellow
n = nothing
g = green
r = red
def health():
  global lives
  if lives == 2:#When the user only has two lives.
    wrong()#Calls a function to change the colour of the arrow to red 
    time.sleep(1)
    sense.set_rotation(Angular)
    sense.show_message("WHOOPS!",scroll_speed = 0.05)#Shows a message for the user.
  elif lives == 1:#When the user only has one lives.
    wrong()#Calls a function to change the colour of the arrow to red 
    time.sleep(1)
    sense.set_rotation(Angular)
    sense.show_message("COME ON ONE MORE TIME",scroll_speed = 0.05)#Shows a message for the user.
  elif lives == 0:#When the user no lives
    wrong()#calls the wrong function which sets the arrow to red
    time.sleep(3)#the program waits for 3 seconds
    sense.set_rotation(Angular)#sets the rotation of the messages to where the user is orientating at
    #displays a message for the user and also displays the score
    sense.show_message("Unlucky! TRY AGAIN NEXT TIME! YOUR SCORE WAS:", scroll_speed = 0.08,text_colour=[255,0,0])
    sense.show_message(str(Score))#Shows the score
    quit()#Exits out of the program
def checking():
  global current
  global RandomAngle
  #This will make sure that the previous angle is not the same as the new angle
  if prev == current:
     Randoms.remove(prev)#removes the previous angle from the randoms list
     RandomAngle = random.choice(Randoms)#Sets the randomangle variable to choose another angle
     sense.set_rotation(RandomAngle)#rotates the screen to the random angle
     sense.set_pixels(arrow)#shows the arrow with the random angle
     current = RandomAngle#sets the current angle 
     Randoms.insert(5,prev)#inserts the previous angle back to the list
  elif prev !=current:# when the previous angle has not got the same value as the current angle
    sense.set_rotation(RandomAngle)#rotates the screen to the random angle
    sense.set_pixels(arrow)#sets the current angle 
    current = RandomAngle
#fills up one line in the arrow each time and is used as a visual timer for the user 
def counter():
  sense.set_pixel(4,7,yellow)
  sense.set_pixel(3,7,yellow)
  time.sleep(GameTime*0.125)
  sense.set_pixel(4,6,yellow)
  sense.set_pixel(3,6,yellow)
  time.sleep(GameTime*0.125)
  sense.set_pixel(4,5,yellow)
  sense.set_pixel(3,5,yellow)
  time.sleep(GameTime*0.125)
  sense.set_pixel(4,4,yellow)
  sense.set_pixel(3,4,yellow)
  time.sleep(GameTime*0.125)
  sense.set_pixel(4,3,yellow)
  sense.set_pixel(3,3,yellow)
  time.sleep(GameTime*0.125)
  sense.set_pixel(4,2,yellow)
  sense.set_pixel(3,2,yellow)
  sense.set_pixel(1,2,yellow)
  sense.set_pixel(2,2,yellow)
  sense.set_pixel(5,2,yellow)
  sense.set_pixel(6,2,yellow)
  time.sleep(GameTime*0.125)
  sense.set_pixel(2,1,yellow)
  sense.set_pixel(3,1,yellow)
  sense.set_pixel(4,1,yellow)
  sense.set_pixel(5,1,yellow)
  time.sleep(GameTime*0.125)
  sense.set_pixel(3,0,yellow)
  sense.set_pixel(4,0,yellow)
  time.sleep(GameTime*0.125)

#sets the arrow to white when a new arrow is called
def new():
  arrow = [
  n,n,n,w,w,n,n,n,
  n,n,w,w,w,w,n,n,
  n,w,w,w,w,w,w,n,
  n,n,n,w,w,n,n,n,
  n,n,n,w,w,n,n,n,
  n,n,n,w,w,n,n,n,
  n,n,n,w,w,n,n,n,
  n,n,n,w,w,n,n,n,
  ]
  sense.set_pixels(arrow) #shows the arrow made above

#sets the arrow to green when the arrow is correctly orientated by the user
def correct():
   arrow = [
   n,n,n,g,g,n,n,n,
   n,n,g,g,g,g,n,n,
   n,g,g,g,g,g,g,n,
   n,n,n,g,g,n,n,n,
   n,n,n,g,g,n,n,n,
   n,n,n,g,g,n,n,n,
   n,n,n,g,g,n,n,n,
   n,n,n,g,g,n,n,n,
   ]
   sense.set_pixels(arrow)
#sets the arrow to red when the timer is below 0 and when the user has not succesfully orientated 
def wrong():
  arrow = [
  n,n,n,r,r,n,n,n,
  n,n,r,r,r,r,n,n,
  n,r,r,r,r,r,r,n,
  n,n,n,r,r,n,n,n,
  n,n,n,r,r,n,n,n,
  n,n,n,r,r,n,n,n,
  n,n,n,r,r,n,n,n,
  n,n,n,r,r,n,n,n,
  ]
  sense.set_pixels(arrow)
  
#sets the layout of the arrow by setting a color to each individual pixel
arrow = [
  n,n,n,w,w,n,n,n,
  n,n,w,w,w,w,n,n,
  n,w,w,w,w,w,w,n,
  n,n,n,w,w,n,n,n,
  n,n,n,w,w,n,n,n,
  n,n,n,w,w,n,n,n,
  n,n,n,w,w,n,n,n,
  n,n,n,w,w,n,n,n,
  ]
sense.set_pixels(arrow)
sense.set_rotation(RandomAngle)#sets a random rotation of the arrow 
def main():
    #a set of global variable which allows the program to change values to the variables
    global prev
    global Score
    global lives
    global GameTime
    global Angular
    while True:
      checking()#Called to make sure that the previous angle is not the same
      new()#Called to make a new arrow
      counter()
      x, y, z = sense.get_accelerometer_raw().values()# uses the sensehat's accelerometer for orientation
      x=round(x,0)
      y=round(y,0)
      #Using the accelerometer raw values of x and y it can identify what angle the rasberry pi is pointing
      if x == -1: 
          Angular = 180  
      elif y == 1:
          Angular = 270
      elif y == -1:
          Angular = 90
      else:
          Angular = 0    
      print(GameTime)
      if Angular == RandomAngle: #when the arrow is facing the correct orientation
       correct()#calls the correct function which sets the arrow to green
       time.sleep(GameTime)#makes the game stop for a period of time which is dictated by the time 
       GameTime *= 0.93 #decreases the time by 7 percent
       Score += 1# increases the score by one
       prev = current
       main()#the main() will be called and the whole process will happen again
      elif Angular != RandomAngle:
        lives -= 1
        health()
main()
