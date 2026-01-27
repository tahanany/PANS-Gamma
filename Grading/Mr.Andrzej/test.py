import power as pow 
import unittest

class TestPowerFn(unittest.TestCase):
    def test1(self):
        self.assertEqual(pow.powerrr(3,2), 9)
    def test2(self):
        self.assertEqual(pow.powerrr(3,10), 59049)
    def test3(self):
        self.assertEqual(pow.powerrr(3,-1), 1/3)
    def test4(self):
        self.assertEqual(pow.powerrr(5,2), 25)

if __name__ == '__main__':
    unittest.main()
