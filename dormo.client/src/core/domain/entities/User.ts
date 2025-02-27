export interface User extends Owner {
    emailSubscription: boolean,
}

export interface Owner {
    id: string,
    email: string,
    firstName: string,
    lastName: string,
    profileImageUrl: string,
    userName: string,
    birthYear: number,
    contactInfo: string,
    isVerified: boolean,
}