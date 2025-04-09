def solution(diffs, times, limit):
    min = 1
    max = 100000
    for i in range(1,16):
        level = (min+max)//2
        print(min,max,level)
        if limit<usingTimeReturn(diffs,times,level):
            min = (max+min)//2
        if limit>usingTimeReturn(diffs,times,level):
            max = (max+min)//2
        if limit==usingTimeReturn(diffs,times,level):
            return level
    
    
    
    for i in range(min,max+1):
        level = i
        if limit<usingTimeReturn(diffs,times,level):
            continue
        if limit>=usingTimeReturn(diffs,times,level):
            break
            
    return level

def usingTimeReturn(diffs,times,level):
    consumeTime = 0
    prevTime = 0
    for i in range(len(diffs)):
        wrongRepeat = diffs[i] - level
        if wrongRepeat>0:
            consumeTime += ((prevTime+times[i])*wrongRepeat)
        consumeTime += times[i]
        prevTime = times[i]
    return consumeTime


        
    