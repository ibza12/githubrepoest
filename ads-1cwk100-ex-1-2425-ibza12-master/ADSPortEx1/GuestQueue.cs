using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx1
{
    //Queue implementation for Assessed Exercise 1

    //Hints : 
    //Use lecture materials from Week 2A
    // and lab sheet 'Lab 2 (second part): Stacks and Queues' to aid with implementation...

    //Do not delete the current function definitions, just replace the exceptions with the required functionality...

    //Don't forget to properly commit and document your work! 
    // Commit fairly frequently with proper descriptions, i.e. commit after implementing the enqueue function...

    //Lastly, don't forget about implementing your UI in 'Form1.cs' too!
    // See lab material from week 1 to aid with this...

    // - Adam.M 

    class GuestQueue
    {

        private int maxsize = 10;
        private Guest[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems = 0;

        // Functions for EX.1A
        public GuestQueue()
        { 
            store = new Guest[maxsize];
        }

        public GuestQueue(int size)
        {
            maxsize = size;
            store = new Guest[maxsize];
        }

        public void Enqueue(Guest value)
        {
            store[tail] = value;
            tail++;
            numItems++;
        }

        public Guest Dequeue()
        {
            Guest headItem = store[head];
            head++;
            numItems--;
            return headItem;
        }

        public Guest Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return store[head];
        }

        public int Count()
        {
            return numItems;
        }

        public bool IsEmpty()
        {
            return (numItems == 0);
        }

        public bool IsFull()
        {
            return numItems = maxsize;  // github push not working proerly so i have to rewrite my push notes again.

        }

        // Functions for EX.1B

       public void Reverse(int k)
{
    if (k > numItems || k <= 0)
    {
        return; // Do nothing if k is invalid.
    }

    int start = head;
    int end = (head + k - 1) % maxsize;

    while (start != end && start != (end + 1) % maxsize)
    {
        // Swap the guests
        Guest temp = store[start];
        store[start] = store[end];
        store[end] = temp;

        // Move pointers
        start = (start + 1) % maxsize;
        end = (end - 1 + maxsize) % maxsize;
    }
}

       public Guest GetMostFunds()
{
    if (IsEmpty())
    {
        return null; // Return null if the queue is empty.
    }

    Guest richestGuest = store[head];
    int index = head;

    for (int i = 1; i < numItems; i++)
    {
        index = (index + 1) % maxsize;
        if (store[index].Funds > richestGuest.Funds)
        {
            richestGuest = store[index];
        }
    }

    return richestGuest;
}


        // See tasksheet for details for EX.1C nice



        //Free space, use as necessary to address task requirements... 







    } // End of class
}
