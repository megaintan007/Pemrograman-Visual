import string
abjad = string.printable

def enkripsi(pesan) :
       global abjad

       key = int(input('Masukkan Key : '))
       cipher = ''
       for i in pesan:
              if i in abjad:
                     k = abjad.find(i)
                     k = (k + key)%100
                     cipher = cipher+abjad[k]
              else:
                     cipher = cipher + i

       return cipher


pesan = input('Masukkan Pesan : ')
print(enkripsi(pesan))