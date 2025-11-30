import andrej.power as power
import unittest

class TestTriangleFn(unittest.TestCase):
    def test1(self):
        self.assertEqual(pow.powerrr(3,2),9)
    def test2(self):
        self.assertEqual(pow.powerrr(3,10),59049)
    def test3(self):
        self.assertEqual(pow.powerrr(3,-1),1/3)
    def test4(self):
        self.assertEqual(pow.powerrr(5,2),25)



if _name__ =='main_':
    unittest.main()