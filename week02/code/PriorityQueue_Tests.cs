using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and then dequeue.
    // Expected Result: Item with highest priority should be dequeued first.
    // Defect(s) Found: Initially, the dequeue didn’t always return the highest priority item.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        var result = pq.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Add items with same highest priority. Should dequeue the one added first
    // Expected Result: FIFO order implemented among equal-priority items.
    // Defect(s) Found: It removed the wrong one (not the first added).
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("FirstHigh", 10);
        pq.Enqueue("SecondHigh", 10);
        pq.Enqueue("Low", 1);

        var first = pq.Dequeue();
        var second = pq.Dequeue();

        Assert.AreEqual("FirstHigh", first);
        Assert.AreEqual("SecondHigh", second);
    }   

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue from empty queue.
    // Expected Result: Throws exception.
    // Defect(s) Found: No exception or wrong error message.
    public void TestPriorityQueue_EmptyQueue()
    {
        var queue = new PriorityQueue();
    
    try
    {
        queue.Dequeue();
        Assert.Fail("Expected exception was not thrown.");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
    }

}