package org.SnakeGame;

public class Main {
    public static void main(String[] args){
        SnakeGame obj = new SnakeGame(3, 2);
       int param_1 = obj.move("R");
        int param_2 = obj.move("D");
        int param_3 = obj.move("R");
        int param_4 = obj.move("U");
        int param_5 = obj.move("L");
        int param_6 = obj.move("U");
    }
}
