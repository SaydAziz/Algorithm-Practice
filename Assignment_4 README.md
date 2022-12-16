Assignment 5 - Searching

    - Bubble Sort
        * Starts at the beginning of an array and swaps the first two elements if the first is greater than the second.
        * Asymptomatic Big O: O(n2) [Best and Worst]
        * Pseudocode: Bubblesort(Data: values[])
                    // Repeat until the array is sorted.
                    Boolean: not_sorted = True
                    While (not_sorted)
                        // Assume we won't find a pair to swap.
                        not_sorted = False
                        // Search the array for adjacent items that are out of order.
                        For i = 0 To <length of values> - 1
                
                        // See if items i and i - 1 are out of order.
                            If (values[i] < values[i - 1]) Then
                                // Swap them.
                                Data: temp = values[i]
                                values[i] = values[i - 1]
                                values[i - 1] = temp
                 
                                // The array isn't sorted after all.
                                not_sorted = True
                                End If
                            Next i
                        End While
                    End Bubblesort  


    - Insertion Sort
        * Builds the final sorted set one item at a time, by comparing its size to the previous index, switching it if larger.
        * Asymptomatic Big O: O(n) [Best], O(n2) [Worst]
        * Pseudocode: Insertionsort(Data: values[])
                        For i = 0 To <length of values> - 1
                    // Move item i into position
                    //in the sorted part of the array
                        < Find  the first index j where
                        j < i and values[j] > values[i].>
                        <Move the item into position j.>
                        Next i
                    End Insertionsort


    - Selection Sort
        * Searches the input list for the largest item it contains and then add it to the end of a growing sorted list.
        * Asymptomatic Big O: O(n2) [Best and Worst]
        * Pseudocode: Selectionsort(Data: values[])
                        For i = 0 To <length of values> - 1
                    // Find the item that belongs in position i.
                        <Find the smallest item with index j >= i.>
                        <Swap values[i] and values[j].>
                        Next i
                    End Selectionsort  


    - Heap Sort
        * Finds the minimum element and place the minimum element at the beginning using a binary tree.
        * Asymptomatic Big O: O(n log n) [Best and Worst]
        * Pseudocode: Heapsort(A) {
                      BuildHeap(A)
                       for i <- length(A) downto 2 {
                          exchange A[1] <-> A[i]
                          heapsize <- heapsize -1
                          Heapify(A, 1)

                      BuildHeap(A) {
                           heapsize <- length(A)
                           for i <- floor( length/2 ) downto 1
                              Heapify(A, i)
                        }
                        
                        
                        
                        
                      Heapify(A, i) {
                           left <- left(i)
                           right <- right(i)
                           if (le<=heapsize) and (A[le]>A[i])
                              largest <- le
                           else
                              largest <- i 
                           if (ri<=heapsize) and (A[ri]>A[largest])
                              largest <- ri
                           if (largest != i) {
                              exchange A[i] <-> A[largest]
                              Heapify(A, largest)
                           }
                        }


    - Quick Sort
        * Splits the items into two halves holding an equal number of items. It then recursively calls itself to sort the two halves.
        * Asymptomatic Big O: O(n log n) [Best and Worst]
        * Pseudocode: Mergesort(Data: values[], Data: scratch[], Integer: start, Integer: end)
                            // If the array contains only one item, it is already sorted.
                        
                        If (start == end) Then Return
                         
                            // Break the array into left and right halves.
                            Integer: midpoint = (start + end) / 2
                         
                            // Call Mergesort to sort the two halves.
                            Mergesort(values, scratch, start, midpoint)
                            Mergesort(values, scratch, midpoint + 1, end)
                         
                            // Merge the two sorted halves.
                            Integer: left_index = start
                            Integer: right_index = midpoint + 1
                            Integer: scratch_index = left_index
                            While ((left_index <= midpoint) And (right_index <= end))
                                If (values[left_index] <= values[right_index]) Then
                                    scratch[scratch_index] = values[left_index]
                                    left_index = left_index + 1
                                Else
                                    scratch[scratch_index] = values[right_index]
                                    right_index = right_index + 1
                                End If
                                scratch_index = scratch_index + 1    End While
                         
                            // Finish copying whichever half is not empty.
                            For i = left_index To midpoint
                                scratch[scratch_index] = values[i]
                                scratch_index = scratch_index + 1
                            Next i
                            For i = right_index To end
                        
                        scratch[scratch_index] = values[i]
                                scratch_index = scratch_index + 1
                            Next i
                            // Copy the values back into the original values array.
                            For i = start To end
                                values[i] = scratch[i]
                            Next i
                        End Mergesort