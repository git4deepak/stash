
def up_low(s):
	lowers = 0
	uppers = 0 
	for c in s:
		if ('a' <= c <= 'z'):
			lowers += 1
		elif ('A' <= c <= 'Z'):
			uppers += 1
	
	print ("No. of Upper case characters : ", uppers)
	print ("No. of Lower case characters : ", lowers)
	

def unique_list(l):
	"""
	Generates list of unique items from given list.
	"""
	s = set(l)
	return list(s)
	
def palindrome(s):
    """
	Returns true if the given string is a palindrome.
    spaces ignored
    """
    s = s.replace(' ', '')
    return s == s [::-1]

#Test all the functions
#up_low("abcABCD1")

#for x in unique_list([1,1,1,1,2,2,3,3,3,3,4,4]):
#	print (x)

if(palindrome("nurses run")):
	print ("Palindrome pass!!")
else:
	print ("Palindrome fail!!")