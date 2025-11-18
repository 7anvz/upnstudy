print("Digite su nombre")
name = input().lower()
#vocales
vocales = "aeiou"
cantVocales = 0
for c in name:
    if c in vocales:
        cantVocales += 1
print(f"Su nombre tiene {cantVocales} vocales")
#invertido
name2 = name.upper()
nomInvertido = name2[::-1]
print(f"Su nombre invertido es : {nomInvertido}")
#en vertical
for c in name:
    print(c)
#en vertical invertido
for c in nomInvertido:
    print(c)