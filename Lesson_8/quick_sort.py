def quck_sort(arr):
    if len(arr) <= 1:
        return arr
    else:
        pivot = arr[0]
        
        left = [x for x in arr[1:] if x < pivot]
        right = [x for x in arr[1:] if x >= pivot]
        
        return quck_sort(left) + [pivot] + quck_sort(right)
    
arr = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5]

sorted_arr = quck_sort(arr)

print(sorted_arr)