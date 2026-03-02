
---
Consider:
- Σ = total set of events (ex.: alphabet);
- Σₒ = observable set of events;
- Σᵤₒ = Σ \ Σₒ = non-observable set of events;
- Σ* = all possible words set (finite sequence) over Σ.
---
**Natural Projection** = P: Σ* -> Σₒ*

Defined for:
- P(ε) = ε
- P(a) = a, if a ∈ Σₒ
- P(a) = ε, if a ∈ Σᵤₒ
- P(s₁s₂) = P(s₁) * P(s₂)

Resume: **natural projection** removes all non-observable events from the sequence.

---
If:
- Σ = {a,b,c}
- Σₒ = {a,c}
- Σᵤₒ = {b}
Then:
P(abcab) = aca