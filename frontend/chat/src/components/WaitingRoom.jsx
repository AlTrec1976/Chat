import {Button, Heading, Text} from "@chakra-ui/react";

export const WaitingRoom = () => {
    return (
        <form className="max-w-sm w-full bg-white p-8 rounded shadow-lg">
            <Heading>Онлайн чат</Heading>
            <div className="mb-4">
                <Text fontSize={"small"}>Имя пользователя</Text>
                <input name="userName" placeholder="Введите ваше имя"/>
            </div>
            <div className="mb-4">
                <Text fontSize={"small"}>Название чата</Text>
                <input name="chatRoom" placeholder="Введите название чата"/>
            </div>
            <Button title="submit" colorScheme="blue">Присоединиться</Button>
        </form>
    );
}