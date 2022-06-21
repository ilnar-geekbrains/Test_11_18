from typing import Sequence


class Polynom:
    def __init__(self, terms: Sequence[int]) -> None:
        self._terms = terms

    @property
    def terms(self) -> Sequence[int]:
        return self._terms

    @property
    def len_polynom(self) -> int:
        return len(self.terms)

    def __mul__(self, other: 'Polynom') -> 'Polynom':
        result = [0] * (self.len_polynom + other.len_polynom - 1)
        for idx1, t1 in enumerate(self.terms):
            for idx2, t2 in enumerate(other.terms):
                result[idx1 + idx2] += t1 * t2
        return Polynom(result)

    def __repr__(self) -> str:
        return str(self.terms)

    def __eq__(self, other: 'Polynom') -> bool:
        return self.terms == other.terms
