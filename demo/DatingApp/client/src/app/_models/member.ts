import { Photo } from "./photo"

export interface Member {
  id: number
  username: string
  age: number
  photoUrl: string
  knownAs: string
  created: Date
  lastActive: Date
  gender: string
  interests: string
  introduction: string
  lookingFor: string
  city: string
  country: string
  photos: Photo[]
}
