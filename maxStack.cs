using System.Collections.Generic;

public class MaxStack{
    Stack<int> maxStack;
    Stack<int> mainStack;

    public MaxStack(){
        mainStack = new Stack<int>();
        maxStack = new Stack<int>();
    }

    public int pop(){
        maxStack.Pop();
        return mainStack.Pop(); 
    }

    public void push(int val){
        mainStack.Push(val);
        if(maxStack.Count == 0 || val > maxStack.Peek()){
            maxStack.Push(val);
        }
        else{
            maxStack.Push(maxStack.Peek());
        }
    }

    public int getMaxRating(){
        return maxStack.Peek();
    }
}