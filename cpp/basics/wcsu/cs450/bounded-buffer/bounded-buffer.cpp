// Alexander Luna | Bounded-Buffer Problem

#include <iostream>
#include <thread>
#include <mutex>
#include <condition_variable>
#include <queue>

// We will ensure the buffer size is smaller than the 
// number of for loops to see if our solution works
const int BUFFER_SIZE = 3;
std::queue<int> buffer;
std::mutex mtx;
std::condition_variable not_full, not_empty;

void producer() {
    // Does the following 10 times
    for (int i = 0; i < 10; ++i) {

        // Thread sleeps for 100ms
        std::this_thread::sleep_for(std::chrono::milliseconds(100));

        // Locks the mutex so only this process can use the shared memory
        std::unique_lock<std::mutex> lock(mtx);

        // If the condition evaluates to false, the thread will wait for the number of items in the buffer to decrease
        // Else if the condition evaluates to true, the thread will not wait and continue its execution
        not_full.wait(lock, [] { return buffer.size() < BUFFER_SIZE; });

        // Create a random int from 0-100
        int item = rand() % 100;

        // Push the int to the end of the buffer
        buffer.push(item);

        // Print out the int that was pushed and the buffer's size
        std::cout << "Item produced: " << item << "\tBuffer size: "
            << buffer.size() << "\t\ti = " << i + 1 << "\t\t(Thread: " << std::this_thread::get_id() << ")\n" ;

        // Unlocked the mutex other so another process can use the shared memory
        lock.unlock();

        // Notifies the consumer that it does not need to wait anymore
        not_empty.notify_all();
    }
}

void consumer() {
    // Does the following 10 times
    for (int i = 0; i < 10; ++i) {

        // Thread sleeps for 200ms
        std::this_thread::sleep_for(std::chrono::milliseconds(200));

        // Locks the mutex so only this process can use the shared memory
        std::unique_lock<std::mutex> lock(mtx);

        // If the condition evaluates to false, the thread will wait for the number of items in the buffer increases
        // Else if the condition evaluates to true, the thread will not wait and continue its execution
        not_empty.wait(lock, [] { return !buffer.empty(); });

        // Grabs int in front of buffer and pops it
        int item = buffer.front();
        buffer.pop();

        // Prints out the int that was grabbed
        std::cout << "Item consumed: " << item << "\tBuffer size: "
            << buffer.size() << "\t\ti = " << i + 1 << "\t\t(Thread: " << std::this_thread::get_id() << ")\n";

        // Unlocked the mutex other so another process can use the shared memory
        lock.unlock();

        // Notifies the producer that it does not need to wait anymore
        not_full.notify_all();
    }
}

int main() {
    // Creates threads
    std::thread producer_thread(producer);
    std::thread consumer_thread(consumer);

    // Waits for threads to finish
    producer_thread.join();
    consumer_thread.join();

    return 0;
}