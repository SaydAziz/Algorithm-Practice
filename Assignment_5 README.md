Assignment 5 - Searching

	-Linear Search
		* Sequentially checks each element of a data set.
		* Asymptomatic Big O: O(1) [Best], O(n) [Worst]
		* Pseudocode:   Begin
						Set i = 0
						If Li = T, go to line 4
						Increase i by 1 and go to line 2
						If i < n then return i
						End
	-Binary Search 
		* Compares the value in the middle of the data set to the value being searched for.
		* Asymptomatic Big O: O(1) [Best], O(log n) [Worst]
		* Pseudocode:	function binary_search(A, n, T) is
						L := 0
						R := n − 1
						while L ≤ R do
							m := floor((L + R) / 2)
						if A[m] < T then
							L := m + 1
						else if A[m] > T then
							R := m − 1
						else:
							return m
						return unsuccessful
	-Interpolation Search
		* Like Binary Search but moves closer to the intended target for split.
		* Asymptomatic Big O: O(log log n) [Best], O(n) [Worst]
		* Pseudocode:	Set Lo  →  0
						Set Mid → -1
						Set Hi  →  N-1

						While X does not match
   
						if Lo equals to Hi OR A[Lo] equals to A[Hi]
							EXIT: Failure, Target not found
						end if
      
						Set Mid = Lo + ((Hi - Lo) / (A[Hi] - A[Lo])) * (X - A[Lo]) 

						if A[Mid] = X
							EXIT: Success, Target found at Mid
							else 
						if A[Mid] < X
							Set Lo to Mid+1
							else if A[Mid] > X
								Set Hi to Mid-1
							end if
						end if
						End While