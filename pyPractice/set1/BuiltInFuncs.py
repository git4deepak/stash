import random
from functools import reduce
def word_length(sentance):
    return (list (map(lambda s: len(s), sentance.split(" "))))

def digits_to_num (digits):
    return int(reduce (lambda a,b: a*10+b, digits))

def filter_words (words, letter):
    return list(filter (lambda w: len(w)>0 and (w[0] == letter), words))

def concatinate (lst1, lst2, connector):
    return [ a + connector + b for (a,b) in zip(lst1, lst2) ]

def d_list(l):
    return {val:count for count, val in enumerate(l)}

def count_match_index(l):
    return len(list(filter (lambda t : t[0] == t[1], enumerate(l))))

def gensquares(n):
    for l in range(0, n):
        yield l*l

def rand_num(low,high,n):
    for x in range(0,n):
        yield random.randint(low, high)