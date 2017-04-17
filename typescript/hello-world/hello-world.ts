export default class HelloWorld {
    constructor() { }
    static hello(name?: string): string {
        if (name == undefined)
        { name = 'World'; }

        return 'Hello, ' + name + '!';
    }

};