import numpy as np


class PolyMult:

    def __init__(self, ):
        self.result = [0]

    def mult(self, poly1, poly2):
        self.result = [0] * (len(poly1) + len(poly2) - (len(poly1) > 0 and len(poly2) > 0))
        for i in range(len(poly1)):
            for j in range(len(poly2)):
                self.result[i + j] += poly1[i] * poly2[j]


class Tests(PolyMult):

    def make_test(self):
        while True:
            print('[INFO] Test is started')
            print('[INFO] Test is started')
            
            poly_1 = [1, 2, 3]
            poly_2 = [1, 2, 3]
            self.mult(poly_1, poly_2)
            assert self.result == list(np.polymul(tuple(poly_1[::-1]), tuple(poly_2[::-1])))[::-1]
            print('[INFO] Base test 1 completed succesfuly')
            
            poly_1 = [1, 2, 3]
            poly_2 = []
            self.mult(poly_1, poly_2)
            assert self.result == list(np.polymul(tuple(poly_1[::-1]), tuple(poly_2[::-1])))[::-1]
            print('[INFO] Base test 2 completed succesfuly')
            
            poly_1 = [10]
            poly_2 = [2]
            self.mult(poly_1, poly_2)
            assert self.result == list(np.polymul(tuple(poly_1[::-1]), tuple(poly_2[::-1])))[::-1]
            print('[INFO] Base test 3 completed succesfuly')
            
            print('Insert the first Polynom as a list where list[i] is a cooficient near i-th power ')
            poly_1 = list(map(int, input('Insert numbers divided with space like "9 1 8" '
                                         ).split()))
            print('Insert the second Polynom as a list where list[i] is a cooficient near i-th power ')
            poly_2 = list(map(int, input('Insert numbers divided with space like "1 4 4" ').split()))
            self.mult(poly_1, poly_2)
            assert self.result == list(np.polymul(tuple(poly_1[::-1]), tuple(poly_2[::-1])))[::-1]
            print('Test is OK')
            if input('Press Q to stop ').lower() == 'q':
                break
